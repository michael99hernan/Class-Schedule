﻿$(document).ready(function () {
    var CoreColor = '#76448A';
    var MPrepColor = '#B03A2E';
    var MajorColor = '#1F618D';
    var MElectColor = '#B9770E';
    var ElectiveColor = '#AF601A ';

    $('a[data-toggle="tab"]').on('shown.bs.tab', function (e) {
        $.fn.dataTable.tables({ visible: true, api: true }).columns.adjust();
    });
    var table = $("#StudentCoursesTable").DataTable({
        ajax: {
            "url": "/StudentCourses/GetStudentCourses",
            "type": "GET",
            "datatype": "json"
        },
        select: true,
        order: [[4, "course.courseType"]],
        columns: [
            { data: "course.prefix" },
            { data: "course.number" },
            { data: "course.name" },
            { data: "course.credits" },
            {
                data: "course.courseType",
                visible: false
            },
            {
                data: "course.courseId",
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
            function(data) {
                var course = data;
            }
        },
        createdRow: function (row, data, dataIndex) {
            if (data.course.courseType == 0) {
                $(row).css('background-color', CoreColor);
            }
            if (data.course.courseType == 1) {
                $(row).css('background-color', MPrepColor);
            }
            if (data.course.courseType == 2) {
                $(row).css('background-color', MajorColor);
            }
            if (data.course.courseType == 3) {
                $(row).css('background-color', MElectColor);
            }
            if (data.course.courseType == 4) {
                $(row).css('background-color', ElectiveColor);
            }

        }

    });
    //Remove Column
    $('#StudentCoursesTable tbody').on('click', 'td a', function () {
        var RowIndex = $(this).closest('tr');
        var data = table.row(RowIndex).data();
        var url = "/StudentCourses/Delete?Id=" + data.id;
        $.ajax({
            url: url,
            type: "GET",
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
            "url": "/StudentCourses/GetMajorCourses",
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
        var RowIndex = $(this).closest('tr');
        var data = table2.row(RowIndex).data();
        var url = "/StudentCourses/Create?CourseId=" + data.courseId;
        $.ajax({
            url: url,
            type: "GET",
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