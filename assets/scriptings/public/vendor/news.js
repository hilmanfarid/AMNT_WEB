$(document).ready(function(){
	$('link[rel=stylesheet][href~="/assets/stylesheets/custom.css"]').remove();
	var container = $('.container-old');
	$(container).removeClass('container-old');
	$(container).addClass('container');
	$('body').addClass('detailNews');
});
