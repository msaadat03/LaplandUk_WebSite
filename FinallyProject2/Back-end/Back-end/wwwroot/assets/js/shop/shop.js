"use strict";
$(function () {
    $(document).on('click', '.categories', function (e) {
        e.preventDefault();
        $(this).next().next().slideToggle();
    })

    $(document).on("click", ".show-more button", function () {

        let parent = $("#parent-products");

        let skipCount = $("#parent-products").children().length;

        let productCount = $("#product-count").val();

        $.ajax({
            url: `/shop/showmore?skip=${skipCount}`,
            type: "Get",
            success: function (response) {

                $(parent).append(response);

                skipCount = $("#parent-products").children().length;

                if (skipCount >= productCount) {
                    $(".show-more button").addClass("d-none");
                }
            }
        });
    });

    $(document).on('click', '.category li a', function (e) {
        e.preventDefault();
        let category = $(this).attr('data-id');
        let products = $('.product-item');

        products.each(function () {
            if (category == $(this).attr('data-id')) {
                $(this).parent().fadeIn();
            }
            else {
                $(this).parent().hide();
            }
        })
        if (category == 'all') {
            products.parent().fadeIn();
        }
    })

    $(document).on("click", "#addToCart", function () {
        let id = $(this).attr('cart-id');
        let basketCount = $("#basketCount")
        let basketCurrentCount = $("#basketCount")
        $.ajax({
            method: "Post",
            url: "/basket/addbasket",
            data: {
                id: id
            },
            content: "application/x-www-from-urlencoded",
            success: function (res) {
                let scrollBasket = $('#basketCount');
                let scrollBasketCount = $(scrollBasket).text();
                scrollBasketCount++;
                $(scrollBasket).text(scrollBasketCount);
                basketCurrentCount = scrollBasketCount;
                basketCount.html("")
                basketCount.append(basketCurrentCount)
            }
        });
    });

    let addHeart = document.querySelectorAll("#shop-product #products .product-item .fa-heart");
    let heartCount = document.querySelector(".heart sup");

    let products = [];

    if (localStorage.getItem("products") != null) {
        products = JSON.parse(localStorage.getItem("products"));
    }

    addHeart.forEach((heartBtn) => {
        heartBtn.addEventListener("click", function (e) {
            heartBtn.classList.toggle("my-active");

            e.preventDefault();

            let productImg =
                this.parentNode.parentNode.parentNode.firstElementChild.firstElementChild.getAttribute(
                    "src"
                );
            let productName =
                this.parentNode.parentNode.parentNode.nextElementSibling.firstElementChild
                    .innerText;
            let productPrice =
                this.parentNode.parentNode.parentNode.nextElementSibling.nextElementSibling.firstElementChild.innerText;
            let productId = parseInt(
                this.parentNode.parentNode.parentNode.parentNode.getAttribute("product-id")
            );

            let existProduct = products.find((m) => m.id == productId);

            if ((existProduct != undefined)) {
                existProduct.count += 0;
            } else {
                products.push({
                    id: productId,
                    image: productImg,
                    name: productName,
                    price: productPrice,
                    count: 1,
                });
            }

            localStorage.setItem("products", JSON.stringify(products));

            heartCount.innerText = getHeartCount(products);
        });
    });

    heartCount.innerText = getHeartCount(products);

    function getHeartCount(heartCount) {
        let count = 0;
        for (const heart of heartCount) {
            count += heart.count;
        }
        return count;
    }

    $(document).on("keyup", ".search-box .input-search", function () {
        let inputVal = $(this).val().trim();

        $("#search-list-product li").slice(0).remove();
        $.ajax({
            url: "shop/search",
            type: "Get",
            contentType: "application/x-www-form-urlencoded",
            data: {
                search: inputVal
            },

            success: function (res) {
                $("#search-list-product").append(res);
            }
        });
    });
});

const rangeInput = document.querySelectorAll(".range-input input"),
    priceInput = document.querySelectorAll(".input-price input"),
    progress = document.querySelector(".range .progress");

let priceGap = 50;

priceInput.forEach((input) => {
    input.addEventListener("input", (e) => {
        let minVal = parseInt(priceInput[0].value),
            maxVal = parseInt(priceInput[1].value);

        if (maxVal - minVal >= priceGap && maxVal <= 631) {
            if (e.target.className === "input-min") {
                rangeInput[0].value = minVal;
                progress.style.left = (minVal / rangeInput[0].max) * 100 + "%";
            } else {
                rangeInput[1].value = maxVal;
                progress.style.right = 100 - (maxVal / rangeInput[1].max) * 100 + "%";
            }
        }
    });
});

rangeInput.forEach((input) => {
    input.addEventListener("input", (e) => {
        let minVal = parseInt(rangeInput[0].value),
            maxVal = parseInt(rangeInput[1].value);

        if (maxVal - minVal < priceGap) {
            if (e.target.className === "range-min") {
                rangeInput[0].value = maxVal - priceGap;
            } else {
                rangeInput[1].value = minVal + priceGap;
            }
        } else {
            priceInput[0].value = minVal;
            priceInput[1].value = maxVal;
            progress.style.left = (minVal / rangeInput[0].max) * 100 + "%";
            progress.style.right = 100 - (maxVal / rangeInput[1].max) * 100 + "%";
        }
    });
});
