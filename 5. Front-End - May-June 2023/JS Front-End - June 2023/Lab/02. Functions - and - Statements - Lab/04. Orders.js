function totalPriceOfAnOrder (product, quantity) {
    let price = {
        'coffee' : 1.5,
        'water' : 1.00,
        'coke' : 1.40,
        'snacks' : 2.00,
    };

    let totalPrice = (price[product]*quantity).toFixed(2);
    console.log(totalPrice);
}

totalPriceOfAnOrder("water", 5);