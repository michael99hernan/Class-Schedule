$(document).ready(function () {
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

        columns: [
            { data: "course.prefix" },
            { data: "course.number" },
            { data: "course.name" },
            { data: "course.credits" }
        ],
        language: {
            "emptyTable": "You have no courses, Please Click <b>Add Course<b>"
        },
        "scrollY": "350px",
        "scrollCollapse": true,
        "paging": false

    });

    $('#StudentCoursesTable tbody').on('click', 'tr', function () {
        if ($(this).hasClass('row_selected')) {
            $(this).removeClass('row_selected');
        }
        else {
            table.$('tr.row_selected').removeClass('row_selected');
            $(this).addClass('row_selected');
        }
    });

    // Delete a record
    $('#DeleteButton').click(function () {
        var data = table.row('.row_selected').data();
        debugger;
        var url = "/StudentCourses/Delete?Id=" + data.id;
        $.ajax({
            url: url,
            type: "GET",
            success: function (data) {
                window.location.href = url;
            },
            error: function (xhr, status, error) {
                var errorMessage = xhr.status + ': ' + xhr.statusText
                alert('Error - ' + errorMessage);
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
            { data: "credits" }
        ],
        "scrollY": "350px",
        "scrollCollapse": true,
        "paging": false
    });

    $('#StudentCoursesNeededtable tbody').on('click', 'tr', function () {
        if ($(this).hasClass('row_selected')) {
            $(this).removeClass('row_selected');
        }
        else {
            table2.$('tr.row_selected').removeClass('row_selected');
            $(this).addClass('row_selected');
        }
    });

    // Add a record
    $('#AddButton').click(function () {
        var data = table2.row('.row_selected').data();
        var url = "/StudentCourses/Create?CourseId=" + data.courseId;
        $.ajax({
            url: url,
            type: "GET",
            success: function (data) {
                location.reload();
            },
            error: function (xhr, status, error) {
                var errorMessage = xhr.status + ': ' + xhr.statusText
                alert("You need PreReqs");
            }
        });
    });

});