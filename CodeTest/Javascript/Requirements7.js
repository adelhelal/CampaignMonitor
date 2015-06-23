
// Finds all anchor tag links with the class name "popup-link" 
// and replaces whatever it finds in the href with an 
// onclick event that calls windows.open()
$(function () {

    $.each($("a.popup-link"), function () {
        var link = $(this).attr("href");
        $(this).attr("href", "#");

        $(this).click(function () {
            var option = $(this).attr("option");
            window.open(link, $(this).attr("data-window-group"), option ? option : "width=500,height=500,top=100,resizable=yes,scrollbars=yes");
            return false;
        });
    })
});
