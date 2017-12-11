$(window).on("load", function () {
    $(".fc-day-grid-container").css("min-height", "385px");
});

$("#calendar").click(function () {
    $(".fc-day-grid-container").css("height", "355px");
    $(".fc-time-grid-container").css("height", "250px");
});

