/// <reference path="Motorcycle.js" />
/// <reference path="Motorcycle.js" />
function getQsBy(key) {
    name = name.replace(/[\[]/, "\\[").replace(/[\]]/, "\\]");
    var regex = new RegExp("[\\?&]" + key + "=([^&#]*)"),
        results = regex.exec(location.search);
    return results == null ? "" : decodeURIComponent(results[1].replace(/\+/g, " "));
}
var ymin;
var mun;
var mod;
var Manufacturers;
$(document).ready(function () {
    if (getQsBy("iadv") == "true") {
        $(".AdvSti-filter").fadeIn();

    }
    else {
        $(".AdvSti-filter").hide();
        $("input[name=iadv]").attr("value", "false");
    }


    var yearHtml = "<option value='' >בחר שנה</option>";
    var today = new Date();
    for (var i = today.getFullYear() ; i >= 1970 ; i--) {
        yearHtml += "<option value='" + i + "'>" + i + "</option>";
    }
    ymin = $("select[name=ymin]");
    ymin.html(yearHtml);

    var Ymin = getQsBy("ymin");
    if (Ymin) $("option[value= " + Ymin + "]", ymin).attr("selected", "selected");

    var ymax = $("select[name=ymax]");
    ymax.html(yearHtml);

    var Ymax = getQsBy("ymax");
    if (Ymax) $("option[value= " + Ymax + "]", ymax).attr("selected", "selected");




    $.ajax({

        url: '/Motorcycle/GetSettings',
        dataType: "json",
        success: function (r) {
            if (r && r.Regions) {

                var regionsSelectJq = $("select[name=reg]")

                regionsSelectJq.append("<option value=''>כל האיזורים</option>");

                for (var i = 0; i < r.Regions.length; i++) {
                    if (!r.Regions[i].PId) {
                        regionsSelectJq.append("<option style='color: red;' value='" + r.Regions[i].Id + "' >" + r.Regions[i].Name + "</option>");
                        for (var j = 0; j < r.Regions.length; j++) {
                            if (r.Regions[j].PId == r.Regions[i].Id) {
                                regionsSelectJq.append("<option value='" + r.Regions[j].Id + "' >" + r.Regions[j].Name + "</option>");
                            }
                        }
                    }
                }

                Manufacturers = r.Manufacturers;
                mun = $("select[name=man]");
                mod = r.Models;
                mun.append("<option  value=''> יצרן</option>");
                for (var t = 0; t < r.Manufacturers.length; t++) {
                    mun.append("<option value=" + Manufacturers[t].Id + ">" + Manufacturers[t].Name + "</Option>");
                }

                //var ger = $("select[name=gt]");
               // ger.append("<option  value=''>גיר</option>");
               // for (var g = 0; g < r.CarGearType.length; g++) {
                   // ger.append("<option value=" + r.CarGearType[g].Id + ">" + r.CarGearType[g].Name + "</option>>");
               /// }

                var ColorQ = $("select[name=clr]");
                ColorQ.append("<option value=\"\">בחר </option>");
                for (var m in r.Colors) {
                    ColorQ.append("<option value='" + r.Colors[m].Id + "'>" + r.Colors[m].Name + "</option>");
                }


                $("#man").click(function (e) {

                    var manPId = $(e.target).val();
                    for (var i = 0; i < Manufacturers.length; i++) {
                        if (Manufacturers[i].Name == manPId) manPId = Manufacturers[i].Id;
                    }
                    var html = "<option  value=''>בחר מודל</option>";
                    for (var z = 0; z < mod.length; z++) {
                        if (mod[z].PId == manPId)
                            html += "<option value='" + mod[z].Id + "'>" + mod[z].Name + "</option>";

                    }
                    var modQUR = $("select[name=mdl]");
                    modQUR.html(html)

                    var modQU = getQsBy("mdl");
                    if (modQU) $("option[value= " + modQU + "]", modQUR).attr("selected", "selected");



                });

                $("td.chak").click(function (e) {
                    //var poinet = $("td.chak");
                    var num = $(e.target).parent().next();
                    if (!num.hasClass("num")) {
                        // var num = $(e.target).parent().closest("tr").children("tr");
                        num.addClass("num");



                        var postId = $(e.target).parent().data("id");
                        datatosend = {
                            PostId: postId,
                            CategoryId: 1,
                        };
                        $.ajax({
                            url: '/Motorcycle/GetFullPost',
                            dataType: "json",
                            data: datatosend,
                            success: function (r) {
                                if (r.Success)
                                    var html = "";
                                var result = r.Item;
                                var picther = r.ItemPics;
                                html += '</br>'
                                html += '<table>'
                                html += '<tr>'
                                html += '<td class="chak">' + 'לפרטים' + '</td>'
                       + '<td>' + result[9] + '</td>'
                                 + '<td class="chak">' + result[8] + '</td>'
                                 + '<td class="chak">' + result[7] + '</td>'
                                 + '<td>' + result[6] + '</td>'
                                 + '<td>' + result[5] + '</td>'
                                 + '<td>' + result[4] + '</td>'
                                 + '<td>' + result[3] + '</td>'
                                 + '<td>' + result[2] + '</td>'
                                 + '<td>' + result[1] + '</td>'
                                 + '</tr>'
                                + '</table>'

                                ;
                                num.css("display", "block");
                                num.html(html);

                            }

                        });
                    }
                    else {
                        num.css("display", "none");
                        num.removeClass("num");

                    }

                });



                var gerq = getQsBy("gt");
                if (gerq) $("option[value= " + gerq + "]", ger).attr("selected", "selected");

                var manfqu = getQsBy("man");
                if (manfqu) $("option[value= " + manfqu + "]", mun).attr("selected", "selected");


                var regFromQs = getQsBy("reg");
                if (regFromQs) $("option[value= " + regFromQs + "]", regionsSelectJq).attr("selected", "selected");

            } else {
                alert("error in data");
            }

        },
        error: function (r) {
            alert("error in request");
        }

    });

});








