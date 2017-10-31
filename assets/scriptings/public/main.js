var n = {
	navigation: function() {
		var n = 0
		  , o = $(window)
		  , i = $('[data-element="top-navigation"]');
		o.on("scroll", function() {
			var t = o.scrollTop();
			i.toggleClass("hide-scroll", t > n),
			n = t
		})
	}
};
$(document).ready(function(){
	$('#lang-list-selector').html('');
	var lang = ['EN','ID'];
	$('.sflanguagesHorizontalList li').each(function( index, element ) {
		var content = $(element).find('a')[0];
		console.log(content.href);
		var classes = $(element).attr('class');
		var contentLang = content.innerHTML;
		contentLang.replace('English','EN');
		contentLang.replace('Bahasa Indonesia','EN');
		$('#lang-list-selector').append('<a class="'+classes+'" href="'+content.href+'"><span>'+lang[index]+'</span></a>');
		var totalLang = $('.sflanguagesHorizontalList li').length;
		if(index != (totalLang-1)){
			$('#lang-list-selector').append('<div class="separator"></div>');
		}
	});
	
	// to stick navbar on top
	//$('.templatemo-top-menu').stickUp();
	
	
	(new WOW).init(),
	n.navigation()
	
}); 