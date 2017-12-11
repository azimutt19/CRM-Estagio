$(document).ready(function () {
    var nextImage = ["/Content/computedlife/img/login1.jpeg", "/Content/computedlife/img/login2.jpeg", "/Content/computedlife/img/login3.jpeg"]
    var imgindex = 0;
    setInterval(function () {
        if (imgindex == 3) {
            imgindex = 0;
        };
        $('body').css("background", "linear-gradient( rgba(0, 0, 0, 0.7), rgba(0, 0, 0, 0.7) ), url('"+nextImage[imgindex++]+"')");
    }, 2000);
});