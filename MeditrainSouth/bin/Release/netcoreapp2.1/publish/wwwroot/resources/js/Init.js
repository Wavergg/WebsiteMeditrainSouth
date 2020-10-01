
$(document).ready(function () {
    $('.parallax').parallax();
    $('select').formSelect();
});


document.addEventListener('DOMContentLoaded', function () {
    var elems = document.querySelectorAll('.carousel');
    var instances = M.Carousel.init(elems, { });
});

$(document).ready(function () {
    $('.carousel.carousel-slider').carousel({
        dist: 0,
        numVisible: 3,
        padding: 30,
    });
});

$(document).ready(function () {
    $('.fixed-action-btn').floatingActionButton();
});

$(document).ready(function () {
    $('.tap-target').tapTarget();
});

var instances;
document.addEventListener('DOMContentLoaded', function() {
    var elems = document.querySelectorAll('.tap-target');
    instances = M.TapTarget.init(elems, {});
});

var isOpen = false;
function featureDiscoveryOpen() {
    $('.tap-target').tapTarget('open');
}

function featureDiscoveryClose() {
    $('.tap-target').tapTarget('close');
}

