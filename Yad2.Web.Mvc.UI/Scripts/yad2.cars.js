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
var modQUR;
var gevia = {
    handlers:{
        getSettingsAjax: function () {
            $.ajax({
                url: '/Cars/GetSettings',
                dataType: "json",
                success: function (r) {
                    if (r) {
                        var mun = $("select[name=man]");
                        var modQUR = $("select[name=mdl]");

                        if (r.Regions) {
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
                        }
                        if (r.Manufacturers) {
                            var mun = $("select[name=man]");
                            mun.append("<option  value=''> יצרן</option>");
                            for (var i = 0; i < r.Manufacturers.length; i++) {
                                if (!r.Manufacturers[i].PId) {
                                    mun.append("<option value='" + r.Manufacturers[i].Id + "' >" + r.Manufacturers[i].Name + "</option>");
                                    for (var j = 0; j < r.Manufacturers.length; j++) {
                                        if (r.Manufacturers[j].PId == r.Manufacturers[i].Id) {
                                            mun.append("<option value='" + r.Manufacturers[j].Id + "' >" + r.Manufacturers[j].Name + "</option>");
                                        }
                                    }
                                }
                            }
                        }
                        $("#man").change(function (e) {
                            var manPId = $(e.target).val();
                            for (var i = 0; i < r.Manufacturers.length; i++) {
                                if (r.Manufacturers[i].Name == manPId) manPId = r.Manufacturers[i].Id;
                            }
                            var html = "<option  value=''>בחר מודל</option>";
                            for (var z = 0; z < r.Models.length; z++) {
                                if (r.Models[z].PId == manPId)
                                    html += "<option value='" + r.Models[z].Id + "'>" + r.Models[z].Name + "</option>";

                            }
                            var modQUR = $("select[name=mdl]");
                            modQUR.html(html)

                            var modQU = getQsBy("mdl");
                            if (modQU) $("option[value= " + modQU + "]", modQUR).attr("selected", "selected");

                        });

                        if (r.CarGearType) {
                            var ger = $("select[name=gt]");
                            ger.append("<option >תיבת הילוכים </option>");
                            for (var i = 0; i < r.CarGearType.length; i++) {
                                if (!r.CarGearType[i].PId) {
                                    ger.append("<option  value='" + r.CarGearType[i].Id + "' >" + r.CarGearType[i].Name + "</option>");
                                    for (var j = 0; j < r.CarGearType.length; j++) {
                                        if (r.CarGearType[j].PId == r.CarGearType[i].Id) {
                                            ger.append("<option value='" + r.CarGearType[j].Id + "' >" + r.CarGearType[j].Name + "</option>");
                                        }
                                    }
                                }
                            }

                        }
                        if (r.Colors) {
                            var ColorQ = $("select[name=clr]");
                            ColorQ.append("<option value=\"\">בחר </option>");
                            for (var m in r.Colors) {
                                ColorQ.append("<option value='" + r.Colors[m].Id + "'>" + r.Colors[m].Name + "</option>");
                            }
                        }


                        var gerq = getQsBy("gt");
                        if (gerq) $("option[value= " + gerq + "]", ger).attr("selected", "selected");


                        var manfqu = getQsBy("man");
                        if (manfqu != null) {
                            $("option[value= " + manfqu + "]", mun).attr("selected", "selected")
                            modQUR = $("select[name=mdl]");
                            var html = "<option  value=''>בחר מודל</option>";

                            for (var z = 0; z < mod.length; z++) {
                                if (mod[z].PId == manfqu) {
                                    html += "<option value='" + mod[z].Id + "'>" + mod[z].Name + "</option>";
                                }

                                modQUR.html(html)
                                var modQU = getQsBy("mdl");
                                if (modQU) $("option[value= " + modQU + "]", modQUR).attr("selected", "selected");
                            }
                        };

                        var regFromQs = getQsBy("reg");
                        if (regFromQs) $("option[value= " + regFromQs + "]", regionsSelectJq).attr("selected", "selected");
                    }
                    else {
                        alert("error in data");
                    }

                },
                error: function (r) {
                    alert("error in request");
                }

            });
        },
        autoCompleteAjax: function () {
            $.ajax({

                url: '/Cars/AutoComplete',
                data: { txt: $(this).val() },
                dataType: "json",
                success: function (r) {
                    $(".auto-comp-res").remove();
                    var resultsDiv = $("<div class='auto-comp-res'></div>")
                    $(r.Values).each(function (i, v) {
                        resultsDiv.append("<div>" + v.substring(0, 13) + "</div>");
                    });

                    var inputTarget = $(e.target);

                    resultsDiv.css({ position: "absolute", top: (inputTarget.offset().top + 26) + "px", left: inputTarget.offset().left + "px", width: inputTarget.width() + "px", "max-width": inputTarget.width() + "px" }).appendTo(document.body);

                    $(document).on("click.autoComp", function (ev) {
                        var target = $(ev.target);

                        if (target.closest(".auto-comp-res").length == 1) $("input[name=txt]").val(target.text());

                        $(document).off("click.autoComp");
                        $(".auto-comp-res").remove();
                    });

                }
            });
        }
    }
}

$(document).ready(function () {


    //השלמה אוטומטית
    $("input[name=txt]").keyup(function (e) {
        gevia.handlers.autoCompleteAjax();
    });

    //מה זה?
    if (getQsBy("iadv") == "true") {
        $(".AdvSti-filter").fadeIn();

    }
    else {
        $(".AdvSti-filter").hide();
        $("input[name=iadv]").attr("value", "false");
    }

    //חיפוש מודעות:
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



    //GetSettings- לסינון חיפוש מודעות
    gevia.handlers.getSettingsAjax();


    $("td.chak").click(function (e) {
        //var poinet = $("td.chak");.

        var dat = $(e.target).parent().next().data("id");
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
                url: '/Cars/GetFullPost',
                dataType: "json",
                data: datatosend,
                success: function (r) {
                    if (r.Success)
                        var html = "";
                    var result = r.Item;
                    var picther = r.ItemPics;
                    html += '</br>'

+ '<div class="full-post-details">'
+ '<div class="pratim">'
   + ' <div>פרטים</div>'
+ '</div>'
+ '<div style="width:175px;>'
    + '<td style="width:175px";>יצרן:' + result[0] + '</td>'
    + '<td style="width:175px";>דגם:' + result[1] + '</td>'
    + '</div>'
    + '<div style="width:175px";>'
   + ' <td style="width:175px";>נפח:' + result[2] + '</td>'
   + ' <td style="width:175px";>שנה:' + result[3] + '</td>'
   + '</div>'
   + '<div style="width:175px";>'
    + '<td style="width:175px";>יד:' + result[4] + '</td>'
    + '<td style="width:175px";>סוג מנוע:' + result[5] + '</td>'
     + '</div>'
     + '<div style="width:175px";>'
    + '<div style="width:175px";>  טסט עד:' + result[6] + '</div>'

    + '<div style="width175px";>ק"מ:' + result[7] + '</div>'
    + '</div>'
    + '<div style="width:175px";>'
    + '<div style="width:175px">צבע הרכב:' + result[8] + '</div>'
    + '<div style="width:175px">בעלות קודמת:' + result[9] + '</div>'
    + '</div>'
    + '<div style="width:175px";>'
    + '<td style="width:175px";>בעלות נוכחית:' + result[10] + '</td>'
    + '<td style="width:175px";>מזגן:' + result[11] + '</div>'
    + '</div>'
    + '<div style="width:175px;>מוכן להחלפה:' + result[12] + '</div>'

+ '</div>'
// +'//<div class="full-post-contect">'
// +'<div class="conect">'
  // + '<h1>צור קשר</h1>'
// +'</div>'
// +'<ul>'
 // +'<li>אזור מכירה:'+ result[0]+'</li>'
  //  +'<li>ישוב:'+ result[0]+'</li>'
    //+'<li>טלפון:'+ result[0]+'</li>'
    //+'<li>איש קשר:'+ result[0]+'</li>'
    //+'<li>דוא"ל:'+ result[0]+'</li>'
    //+'</ul>'
//+'</tr>'

+ '</table>'


                    $("#removmarks").css("display", "block");
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
});








