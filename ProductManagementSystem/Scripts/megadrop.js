(function (e) {
    e(function () {
        e(".toggle-nav").on("click", function (t) {            
            var n = e(t.currentTarget);
            var id = n.attr('id');
            if (n.hasClass("open")) { //if closing the topics dropdown                
                (n.removeClass("open"), n.removeClass("megadroplinkup"), n.addClass("megadroplinkdown"), e("#megaDrop_" + id).slideUp(400));
            }
            else { //if opening the dropdown
                $(".open").removeClass("open");                
                    e(".megadrop").slideUp(400);
                    (n.addClass("open"), n.addClass("megadroplinkup"), n.removeClass("megadroplinkdown"), e("#megaDrop_" + id).slideDown(400));
            }
        })
    })
})(jQuery);
