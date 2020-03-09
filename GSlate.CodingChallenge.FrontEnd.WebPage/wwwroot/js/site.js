// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.



$(document).ready(
    //Function to get Projects by User
    function () {
        $("#UserSelector").change(function () {
            var id = $(this).val();
            $("#DivGrid").html(""); //Clear Div

            $.ajax({
                type: "POST",
                url: "/Home/RequestProjects",
                data: { Id: id },
                dataType: "JSON",
                success: function (__data) {
                    CreateGrid(__data);
                },
                error: function (req, status, error) {
                    alert(error);
                }
            });
        });
    });

function CreateGrid(data) {
    var container = $("#DivGrid");

    $.each(data, function (key, row) {

        var Content =
            '<div class="row">' +
            '<div class="col-2 center">' + row['projectId'] + '</div>' +
            '<div class="col-2 center">' + row['startDate'].slice(0, 10) + '</div>' +
            '<div class="col-2 center">' + row['timeToStart'] + '</div>' +
            '<div class="col-2 center">' + row['endDate'].slice(0, 10) + '</div>' +
            '<div class="col-2 center">' + row['credits'] + '</div>' +
            '<div class="col-2 center">' + row['status'] + '</div>' +
            '</div>';

        $(Content).appendTo('#DivGrid');
    });
}