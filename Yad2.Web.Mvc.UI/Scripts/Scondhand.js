function getQsBy(key) {
    name = name.replace(/[\[]/, "\\[").replace(/[\]]/, "\\]");
    var regex = new RegExp("[\\?&]" + key + "=([^&#]*)"),
        results = regex.exec(location.search);
    return results == null ? "" : decodeURIComponent(results[1].replace(/\+/g, " "));
}
var Manufacturers;
var mun;
var mod;
$(document).ready(function () {

   
     $("input[name=txt]").keyup(function (e) {

         $.ajax({

             url: '/Secondhand/AutoComplete',
             data: { txt: $(this).val() },
             dataType: "json",
             success: function (r) {
                 $(".auto-comp-res").remove();
                 var resultsDiv = $("<div class='auto-comp-res'></div>")
                 $(r.Values).each(function(i,v){
                     resultsDiv.append("<div>" + v.substring(0,13) + "</div>");
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

     });


  


















    $.ajax({
        url: '/Secondhand/GetSettings',
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
                Manufacturers = r.Categories;
                mun = $("select[name=cat]");
                mod = r.SubCategories;
                mun.append("<option  value=''> יצרן</option>");
                for (var t = 0; t < Manufacturers.length; t++) {
                    mun.append("<option value=" + Manufacturers[t].Id + ">" + Manufacturers[t].Name + "</Option>");
                }

                var manfqu = getQsBy("cat");
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
   // $(".cl").click(alert("שלח"))
    $("#cat").click(function (e) {
        
        var manPId = $(e.target).val();
        //for (var i = 0; i < Manufacturers.length; i++) {
            //if (Manufacturers[i].Id == manPId) manPId = Manufacturers[i].Id;
       // }
        var html = "<option  value=''>בחר מודל</option>";
        for (var z = 0; z < mod.length; z++) {
            if (mod[z].PId == manPId)
                html += "<option value='" + mod[z].Id + "'>" + mod[z].Name + "</option>";

        }
       
        var modQUR = $("select[name=subcat]");
        modQUR.html(html)

        var modQU = getQsBy("subcat");
        if (modQU) $("option[value= " + modQU + "]", modQUR).attr("selected", "selected");


    });

 


});