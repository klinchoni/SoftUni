"use strict";

function cookNum (number, ...commands) {
    let sum = Number(number);

    for (let i = 0; i < commands.length; i++) {
        const command = commands [i];

        switch (command) {
            case "chop":
                sum = sum / 2;
                break;
            case "dice":
                sum = Math.sqrt(sum);
                break;
            case "spice":
                sum += 1;
                break;
            case "bake":
                sum *= 3;
                break;
            case "fillet":
                sum -= sum * 0.2;
                break;
        }

        console.log(sum);
    }
}

cookNum('9', 'dice', 'spice', 'chop', 'bake', 'fillet');