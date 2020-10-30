$(document).ready(function () {
    var CoreColor = '#BB8FCE';
    var MPrepColor = '#7FB3D5';
    var MajorColor = '#F7DC6F';
    var MElectColor = '#F0B27A';
    var ElectiveColor = '#F8C471';

    $('a[data-toggle="tab"]').on('shown.bs.tab', function (e) {
        $.fn.dataTable.tables({ visible: true, api: true }).columns.adjust();
    });
    var scheduleId = $('#StudentCoursesNeededtable').data("id");

    var table = $("#ScheduleTable").DataTable({
        ajax: {
            "url": "/Schedules/GetStudentSchedule",
            "type": "GET",
            "datatype": "json",
            data: {scheduleId: scheduleId}
                   
        },
        select: true,
        order: [[4, "courseType"]],
        columns: [
            { data: "prefix" },
            { data: "number" },
            { data: "name" },
            { data: "credits" },
            {
                data: "courseType",
                visible: false
            },
            {
                data: "courseId",
                render: function (data) {
                    return "<a class='btn btn-link '><i class='fas fa-trash'></i></a>";
                }
            }
        ],
        pagingType: "numbers",
        language: {
            "emptyTable": "You have no courses, Please Click <b>Add<b>"
        },
        success: {
            function (data) {
                var course = data;
            }
        },
        createdRow: function (row, data, dataIndex) {
            if (data.courseType == 0) {
                $(row).css('background-color', CoreColor);
            }
            if (data.courseType == 1) {
                $(row).css('background-color', MPrepColor);
            }
            if (data.courseType == 2) {
                $(row).css('background-color', MajorColor);
            }
            if (data.courseType == 3) {
                $(row).css('background-color', MElectColor);
            }
            if (data.courseType == 4) {
                $(row).css('background-color', ElectiveColor);
            }

        }

    });
    //Remove Column
    $('#ScheduleTable tbody').on('click', 'td a', function () {
        var RowIndex = $(this).closest('tr');
        var data = table.row(RowIndex).data();
        var url = "/Schedules/RemoveFromSchedule";
        $.ajax({
            url: url,
            data: {
                scheduleId: scheduleId,
                courseId: data.courseId
            },
            success: function (data) {
                table.ajax.reload();
                table2.ajax.reload();
                $.notify("Removed Course", {
                    globalPosition: "bottom right",
                    className: "success"
                })
            },
            error: function (xhr, status, error) {
                $.notify("Error removing course", {
                    globalPosition: "bottom right",
                    className: "error"
                })
            }
        });
    });


    //COURSES NEEDED TABLE
    var table2 = $("#StudentCoursesNeededtable").DataTable({
        ajax: {
            "url": "/Schedules/GetMajorCourses",
            "type": "GET",
            "datatype": "json"
        },
        columns: [
            { data: "prefix" },
            { data: "number" },
            { data: "name" },
            { data: "credits" },
            {
                data: "courseType",
                visible: false
            },
            {
                data: "courseId",
                render: function (data) {
                    return "<a class='btn btn-link'><i class='fas fa-plus-circle'></i></a>";
                }
            }
        ],
        pagingType: "numbers",
        language: {
            "emptyTable": "No more courses are needed!"
        },
        order: [[4, "asc"]],
        createdRow: function (row, data, dataIndex) {
            if (data.courseType == 0) {
                $(row).css('background-color', CoreColor);
            }
            if (data.courseType == 1) {
                $(row).css('background-color', MPrepColor);
            }
            if (data.courseType == 2) {
                $(row).css('background-color', MajorColor);
            }
            if (data.courseType == 3) {
                $(row).css('background-color', MElectColor);
            }
            if (data.courseType == 4) {
                $(row).css('background-color', ElectiveColor);
            }

        }

    });
    // Add a record
    $('#StudentCoursesNeededtable tbody').on('click', 'td a', function () {
        var scheduleId = $('#StudentCoursesNeededtable').data("id");
        var RowIndex = $(this).closest('tr');
        var data = table2.row(RowIndex).data();
        var url = "/Schedules/AddtoSchedule";
        $.ajax({
            url: url,
            type: "GET",
            data: {
                scheduleId: scheduleId,
                courseId: data.courseId
            },
            success: function (data) {
                table.ajax.reload();
                table2.ajax.reload();
                $.notify("Added Course", {
                    globalPosition: "bottom right",
                    className: "success"
                })
            },
            error: function () {
                $.notify("You need Prerequisite", {
                    globalPosition: "bottom right",
                    className: "info"
                })
            }
        });
    });
});