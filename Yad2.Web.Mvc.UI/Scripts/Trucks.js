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
    var yearHtml = "<option>בחר שנה</option>";
    var today = new Date();
    for (var i = today.getFullYear() ; i >= 1970 ; i--) {
        yearHtml += "<option value='" + i + "'>" + i + "</option>";
    }
    ymin = $("select[name=ymin]");
    ymin.html(yearHtml);

    var Ymin = getQsBy("man");
    if (Ymin) $("option[value= " + Ymin + "]", ymin).attr("selected", "selected");

    var ymax = $("select[name=ymax]");
    ymax.html(yearHtml);

    var Ymax = getQsBy("man");
    if (Ymax) $("option[value= " + Ymax + "]", ymax).attr("selected", "selected");


    //$("#text").keypress(function(e){

    //    var AutoCompleteFilterObject = {
    //        text:$("#text").val(),



    //    }



    //    $.ajax({
    //        url: '/Cars/AutoComplete',
    //        dataType: "json",
    //        date: AutoCompleteFilterObject,
    //        success: function (r) {

    //            }
    //    });
    //});

    $.ajax({
        url: '/Trucks/GetSettings',
        dataType: "json",
        success: function (r) {
            if (r && r.Regions) {

                var regionsSelectJq = $("select[name=reg]")

                regionsSelectJq.append("<option >כל האיזורים</option>");

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
                mun.append("<option> יצרן</option>");
                for (var t = 0; t < r.Manufacturers.length; t++) {
                    mun.append("<option value=" + Manufacturers[t].Id + ">" + Manufacturers[t].Name + "</Option>");
                }

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



    $("#man").change(function (e) {

        var manPId = $(e.target).val();
        // for (var i = 0; i < Manufacturers.length; i++) {
        // if (Manufacturers[i].Name == manPId) manPId = Manufacturers[i].Id;
        // }
        var html = "<option>בחר מודל</option>";
        for (var z = 0; z < mod.length; z++) {
            if (mod[z].PId == manPId)
                html += "<option value='" + mod[z].Id + "'>" + mod[z].Name + "</option>";

        }
        var modQUR = $("select[name=mdl]");
        modQUR.html(html)

        var modQU = getQsBy("mdl");
        if (modQU) $("option[value= " + modQU + "]", modQUR).attr("selected", "selected");
    });


});

