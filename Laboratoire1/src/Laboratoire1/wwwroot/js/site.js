/**
 * 
 * Yan Ha Routhier-Chevrier
 * contenu javascript pour tout les pages
 * 
 * */
// Write your JavaScript code.
$(document).ready(function () {
    $("#message-alert").each(function (i, e) {
        var type = e.getAttribute("data-type");
        var message = e.getAttribute("data-message");

        if (type === "undefined") {
            alert("Something is not working. [showMessage] => " + type + " : " + message);
        } //error
        else if (type == "0" || type == "ERROR") {
            $("body").prepend("<div class='alert alert-danger alert-dismissible fade show' role='alert'>"
                + message
                + "<button type='button' class='close' data-dismiss='alert' aria-label='Close'>"
                + "<span aria-hidden='true'>&times;</span></button></div>");
        } else if (type == "1" || type == "SUCCESS") {
            $("body").prepend("<div class='alert alert-success alert-dismissible fade show' role='alert'>"
                + message
                + "<button type='button' class='close' data-dismiss='alert' aria-label='Close'>"
                + "<span aria-hidden='true'>&times;</span></button></div>");
        }
    });
});
