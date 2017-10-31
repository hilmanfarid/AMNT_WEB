var top_menu_height = 0;
jQuery(function($) {
		$(window).load( function() {
			$('.external-link').unbind('click');	
		});
		
        $(document).ready( function() {

        top_menu_height = $('.templatemo-top-menu').height();
        // scroll spy to auto active the nav item
        $('body').scrollspy({ target: '#templatemo-nav-bar', offset: top_menu_height + 10 });
		$('.external-link').unbind('click');

        // scroll to top
        $('#btn-back-to-top').click(function(e){
            e.preventDefault();
            scrollTo('#templatemo-carousel');
        });

        // scroll to specific id when click on menu
        $('.templatemo-top-menu .navbar-nav a').click(function(e){
            e.preventDefault(); 
            var linkId = $(this).attr('href');
            scrollTo(linkId);
            if($('.navbar-toggle').is(":visible") == true){
                $('.navbar-collapse').collapse('toggle');
            }
            $(this).blur();
            return false;
        });
    });
});

// scroll animation 
function scrollTo(selectors)
{
    if(!$(selectors).size()) return;
    var selector_top = $(selectors).offset().top - top_menu_height;
    $('html,body').animate({ scrollTop: selector_top }, 'slow');

}
$(document).ready(function() {
	var owl = $('.owl-carousel');
	owl.owlCarousel({
	//margin: 10,
	nav: true,
	loop: true,
	responsive: {
		0: {
		items: 1
		},
		600: {
		items: 3
		},
		1000: {
		items: 3
		}
	}
	})
})

$(document).ready(function(){	
	$('.sub-nav-menu a').css('display','block');
}); 

var titles = $('#my-carousel .item h2');;
$.each(titles, function( index, value ) {
	var selected = '';
	if (index == 0){
		selected = 'selected';
	}
	$('#carousel-custom-dots').append('<div class="item owl-dot '+selected+'">' + value.innerText + '</div>')
});
var owl = $('#my-carousel').owlCarousel({
	loop:false,
	items:1,
	nav:false,
	dots : false,
	stagePadding: 0,
	margin:0
});


var owl_dots = $('#carousel-custom-dots').owlCarousel({
	margin:15,
	height : '35px',
	loop:false,
	items:5,
	nav:true,
	dots : false,
	width: "100px",
	slideBy:5,
	center:false
});
owl.on('changed.owl.carousel', function(event) {
    owl_dots.trigger('to.owl.carousel', [event.item.index, 300]);
	$('.owl-nav-about .owl-dot').removeClass('selected');
	$(owl_dots).find('.owl-dot').eq(event.item.index).addClass('selected');
});
$('#carousel-custom-dots > div.owl-stage-outer > div > div').click(function () {
	owl.trigger('to.owl.carousel', [$(this).index(), 300]);
	$('.owl-nav-about .owl-dot').removeClass('selected');
	$(this).find('.owl-dot').addClass('selected');
});
