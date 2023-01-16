$(function () {
    $("#div3 img").mouseover(function () {
        document.getElementById("foto").src = this.src;
    });


    let products = [];

    if (localStorage.getItem("products") != null) {
        products = JSON.parse(localStorage.getItem("products"));
    }

    let heartCount = document.querySelector(".heart sup");

    heartCount.innerText = getHeartCount(products);

    function getHeartCount(heartCount) {
        let count = 0;
        for (const heart of heartCount) {
            count += heart.count;
        }
        return count;
    }

    $(document).on("click", ".detail .add-btn", function () {

        let productId = parseInt($($(this).closest("#product-detail")[0]).attr('product-id'));

        let data = { id: productId };

        $.ajax({
            url: "/productdetail/addbasket",
            type: "Post",
            data: data,
            contentType: "application/x-www-form-urlencoded",
            success: function (res) {

            }
        })
    });
});
