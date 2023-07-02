function calculator (number, operator, number2) {
    let result = {
        '+' : number + number2,
        '-' : number - number2,
        '*' : number * number2,
        '/' : number / number2,
    }

    console.log(result[operator].toFixed(2));
}