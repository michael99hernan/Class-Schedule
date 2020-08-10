$(document).ready(function () {
    var id = $("#PreReqTable").data("id");
    debugger;
    var table = $("#PreReqTable").DataTable({
        ajax: {
            "url": "/Courses/GetPreReqs?id=" + id,
            "type": "GET",
            "datatype": "json"
        },
        columns: [
            { data: "prefix" },
            { data: "number" },
            { data: "name" },
            { data: "credits" }
        ],
        language: {
            "emptyTable": "No PreRequisites"
        },
        "paging": false,
        bFilter: false,

    });

    var table2= $("#CoReqTable").DataTable({
        ajax: {
            "url": "/Courses/GetCoReqs?id=" + id,
            "type": "GET",
            "datatype": "json"
        },
        columns: [
            { data: "prefix" },
            { data: "number" },
            { data: "name" },
            { data: "credits" }
        ],
        language: {
            "emptyTable": "No CoRequisites"
        },
        bFilter: false,
        "paging": false

    });

});