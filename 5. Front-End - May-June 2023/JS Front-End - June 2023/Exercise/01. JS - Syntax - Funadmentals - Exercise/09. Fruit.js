function calculateFruitPrice (fruit, weightInGrams, pricePerKilogram) {
    const weightInKilograms = weightInGrams/1000;
    const totalPrice = (weightInKilograms * pricePerKilogram);

    console.log (`I need $${totalPrice.toFixed(2)} to buy ${weightInKilograms.toFixed(2)} kilograms ${fruit}.`);
}

calculateFruitPrice('apple', 1563, 2.35);