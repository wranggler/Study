$(function(){

	$(".btn-mobile").on("click", function() {
		$(".header-menu").slideToggle("fast");
	});

	$(".header-menu").on("click","a", function (event) {
        event.preventDefault();
        var id  = $(this).attr('href'),
            top = $(id).offset().top;
        $('body,html').animate({scrollTop: top}, 1500);
    });

    $(".main-subtitle").on("click","a", function (event) {
        event.preventDefault();
        var id  = $(this).attr('href'),
            top = $(id).offset().top;
        $('body,html').animate({scrollTop: top}, 1500);
    });

    $(".kurs-invite").on("click","a", function (event) {
        event.preventDefault();
        var id  = $(this).attr('href'),
            top = $(id).offset().top;
        $('body,html').animate({scrollTop: top}, 1500);
    });

	$(window).scroll(function() {
 
		if($(this).scrollTop() != 0) {
		 
		$('#toTop').fadeIn();
		 
		} else {
		 
		$('#toTop').fadeOut();
		 
		}
		 
	});
 
	$('#toTop').click(function() {
	 
	$('body,html').animate({scrollTop:0},800);
	 
	});

});