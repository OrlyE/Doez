function setCookie(cname, cvalue, exdays) {
    var d = new Date();
    d.setTime(d.getTime() + (exdays * 24 * 60 * 60 * 1000));
    var expires = "expires=" + d.toGMTString();
    document.cookie = cname + "=" + cvalue + "; " + expires;
}

function getCookie(cname) {
    var name = cname + "=";
    var ca = document.cookie.split(';');
    for (var i = 0; i < ca.length; i++) {
        var c = ca[i].trim();
        if (c.indexOf(name) == 0) return c.substring(name.length, c.length);
    }
    return "";
}

var cookiesNames = {
    carsFav: "carsF"
}


$(document).ready(function () {

    $(".removmark").click(function (e) {
        var newCookieData = "";

        setCookie(cookiesNames.carsFav, newCookieData, 1);

        $(".fav-checked").removeClass("fav-checked");


        var removec = getCookie(cookiesNames.carsFav);
        //var removecArr = removec.split(',');
        //var removenew = new Array();
        // for (var i = 1; i <= removecArr.length - 1; i++) {
        // removenew[i] = removecArr[i];

        //}



    });

    var carsFavCookie = getCookie(cookiesNames.carsFav);

    if (carsFavCookie) {
        var carIdsArr = carsFavCookie.split(',');
        for (var i = 0; i < carIdsArr.length; i++) {
            $("tr[data-id=" + carIdsArr[i] + "] td.fav").addClass("fav-checked");
        }
    }

    $("td.fav").click(function (e) {

        var postId = $(e.target).parent().data("id");  // $(e.target).parent().attr("data-id");

        var carsFavCookie = getCookie(cookiesNames.carsFav);

        if (!carsFavCookie) {
            setCookie(cookiesNames.carsFav, postId, 1);
            $(e.target).addClass("fav-checked");
        }

        var carIdsArr = carsFavCookie.split(',');

        var i;
        for (i = 0; i < carIdsArr.length; i++) {
            if (carIdsArr[i] == postId) break;
        }

        if (i == carIdsArr.length) { // can add
            setCookie(cookiesNames.carsFav, carsFavCookie + "," + postId, 1);
            $(e.target).addClass("fav-checked");
        }
        else {
            for (i = 0; i < carIdsArr.length; i++) {
                if (carIdsArr[i] == postId) {
                    carIdsArr.splice(i, 1);
                    break;
                }
            }

            var newCookieData = "";
            for (i = 0; i < carIdsArr.length; i++) {
                if (i == 0) newCookieData += carIdsArr[i];
                else newCookieData += "," + carIdsArr[i];
            }
            setCookie(cookiesNames.carsFav, newCookieData, 1);

            $(e.target).removeClass("fav-checked");
        }

    });

    $(".tests").click(function (e) {
        e.preventDefault();

        var mark = getCookie(cookiesNames.carsFav);
        var carIdsArr = mark.split(',');
        var mycars = new Array();
        for (var i = 1; i <= carIdsArr.length - 1; i++) {
            mycars[i] = carIdsArr[i];
        }
        datatosend = {
            PostsIds: mycars,

        };
        //
        if (mycars.length > 0) {
            $.ajax({
                url: '/Jeep/GetMarkedPosts',
                type: "POST",
                dataType: "json",
                contentType: 'application/json',
                data: JSON.stringify(datatosend),
                success: function (r) {
                    if (r.Success)

                        var tblBodySelector = $(".items-tbl tbody");
                    var html = "";
                    var Items = r.Items;
                    for (var i = 0; i < Items.length; i++) {

                        html += '<tr data-id="' + Items[i][0] + '" >'
                        html += '<td class="chak">' + 'לפרטים' + '</td>'
               + '<td>' + Items[i][9] + '</td>'
                         + '<td class="chak">' + Items[i][8] + '</td>'
                         + '<td class="chak">' + Items[i][7] + '</td>'
                         + '<td>' + Items[i][6] + '</td>'
                         + '<td>' + Items[i][5] + '</td>'
                         + '<td>' + Items[i][4] + '</td>'
                         + '<td>' + Items[i][3] + '</td>'
                         + '<td>' + Items[i][2] + '</td>'
                         + '<td>' + Items[i][1] + '</td>'
                        + '<td class="fav addModaa fav-checked"></td>'

                        html += '</tr>';
                        $(".removmark").css("display", "block");

                        //html +='<tr>'
                        //for (var t = 0; t <10;t++) {
                        // var ttt=Items.length[i];

                        //html += '<td data-id="' + Items[i][t] + '"</td>'
                        //}
                        //html += '</tr>';
                    }
                    tblBodySelector.html(html);


                }

            });
        }
    });


    // if ($(".fav")(hasClass("fav-checked"))){
    // chek.addClass("")
    //}

});

$("td.fav").click(function (e) {

    var postId = $(e.target).parent().data("id");  // $(e.target).parent().attr("data-id");

    var carsFavCookie = getCookie(cookiesNames.carsFav);

    if (!carsFavCookie) {
        setCookie(cookiesNames.carsFav, postId, 1);
        $(e.target).addClass("fav-checked");
    }

    var carIdsArr = carsFavCookie.split(',');

    var i;
    for (i = 0; i < carIdsArr.length; i++) {
        if (carIdsArr[i] == postId) break;
    }

    if (i == carIdsArr.length) { // can add
        setCookie(cookiesNames.carsFav, carsFavCookie + "," + postId, 1);
        $(e.target).addClass("fav-checked");
    }
    else {
        for (i = 0; i < carIdsArr.length; i++) {
            if (carIdsArr[i] == postId) {
                carIdsArr.splice(i, 1);
                break;
            }
        }

        var newCookieData = "";
        for (i = 0; i < carIdsArr.length; i++) {
            if (i == 0) newCookieData += carIdsArr[i];
            else newCookieData += "," + carIdsArr[i];
        }
        setCookie(cookiesNames.carsFav, newCookieData, 1);

        $(e.target).removeClass("fav-checked");
    }

});
