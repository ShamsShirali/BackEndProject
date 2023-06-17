$(document).ready(function () {
    let page = window.location.pathname.split('/')[1];

    console.log(page.length)

    if (page.length == 0) {
        $('.Home').addClass('active');
    }
    else {
        $('.' + page).addClass('active');
    }

    $('.searchBtn').click(function (e) {
        e.preventDefault();

        let search = $('.searchInput').val();
        let categoryId = $('.categoriesList').val();

        if (search.length >= 3) {
            fetch('product/search/' + categoryId + '?search' + search)
                .then(res => {
                    return res.text();
                    //return res.json();
                })
                .then(data => {
                    //let liıtem = "";

                    //for (var i = 0; i < data.length; i++) {
                    //    let li =` <li>
                    //<a href="#" class="d-flex justify-content-between align-items-center">
                    //    <img style="width:100px;" src="~/images/product/${data[i].mainımage}" />
                    //    <p>${data[i].title}</p>
                    //    <del class="price-old">£${data[i].price}</del>
                    //</a>
                    //                </li > `;
                    //
                    //    liıtem += li;
                    // }

                    $('.searchList').html(data);
                    //$('.searchList').html(liItem);
                })
        }

        console.log(search + ' ' + categoryId);
    })

    $('.searchInput').keyup(function () {
        let search = $(this).val();

        if (search.length < 3) {
            $('.searchList').html("");
        }
    })

    $('.modalBtn').click(function (e) {
        e.preventDefault();

        let url = $(this).attr('href');

        fetch(url)
            .then(res => res.text())
            .then(data => {
                $('.modal-content').html(data);
                $('.product-details-slider').slick({
                    slidesToShow: 1,
                    arrows: false,
                    fade: true,
                    draggable: false,
                    swipe: false,
                    asNavFor: ".product-slider-nav",
                });

                $('.product-slider-nav').slick({
                    infinite: true,
                    autoplay: true,
                    autoplaySpeed: 8000,
                    slidesToShow: 4,
                    arrows: true,
                    prevArrow: { buttonClass: "slick-prev", iconClass: "fa fa-chevron-left" },
                    nextArrow: { buttonClass: "slick-next", iconClass: "fa fa-chevron-right" },
                    asNavFor: ".product-details-slider",
                    focusOnSelect: true
                });
            })
    })

    $(document).on('click', '.basketBtn', function (e) {
        e.preventDefault();

        let url = $(this).attr('href');

        fetch(url)
            .then(res => res.text())
            .then(data => {
                $('.main-navigation').html(data)
            })
    })
})