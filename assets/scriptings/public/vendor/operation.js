var operations = $('#wrapper section');
$('#wrapper > div').css('width',operations.length+'00vw');
var sect_width = 100/operations.length;
$('#wrapper .section').css('width',sect_width+'%');
$.each(operations, function( index, value ) {
	if(operations.length == 1){
		return;
	}
	var next_title = $(this).next().find('.button-order h2').html();
	if($(this).prev().length==0 && $(this).next().length > 0){
		
		$(value).find('.button-order').append(
			'<button class="btn btn--ghost btn-first" data-scroll="#'+ $(this).next()[0].id +'">'+next_title+' ><i class="icon-angle-right"></i></button>'
		)
	}else if($(this).next().length > 0 && $(this).prev().length > 0){
		var prev_title = $(this).prev().find('.button-order h2').html();
		$(value).find('.button-order').append(
			'<ul class="list--inline">'+
				'<li><button class="btn btn--ghost btn-prev" data-scroll="#'+$(this).prev()[0].id+'"><i class="icon-angle-left"></i>< '+prev_title+'</button></li>'+
				'<li><button class="btn btn--ghost" data-scroll="#'+$(this).next()[0].id+'">'+next_title+' ><i class="icon-angle-right"></i></button></li>'+
			'</ul>'
		)
	}else{
		var prev_title = $(this).prev().find('.button-order h2').html();
		$(value).find('.button-order').append(
			'<button class="btn btn--ghost btn-first" data-scroll="#'+ $(this).prev()[0].id +'"> < '+prev_title+'<i class="icon-angle-right"></i></button>'
		)
	}
	console.log($(value).id);
});


var sweetScroll = new SweetScroll({
  horizontalScroll: true
}, "#wrapper");
$('body').addClass('operation');

