// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function select(e) {

    if (e == e.parentNode.children[0]) {
        e.classList.remove("loser");
        e.classList.remove("winner");

        e.nextElementSibling.classList.remove("loser");
        e.nextElementSibling.classList.remove("winner");

        e.classList.add("winner");
        e.nextElementSibling.classList.add("loser");
    }
    else if (e == e.parentNode.children[1]) {

        e.classList.remove("loser");
        e.classList.remove("winner");

        e.previousElementSibling.classList.remove("loser");
        e.previousElementSibling.classList.remove("winner");

        e.classList.add("winner");
        e.previousElementSibling.classList.add("loser");
    }
}

var tds = document.getElementsByTagName("td");
for (var i = 0; i < tds.length; i++) {
    tds[i].addEventListener("click", function () {
        select(this);
    });
}
