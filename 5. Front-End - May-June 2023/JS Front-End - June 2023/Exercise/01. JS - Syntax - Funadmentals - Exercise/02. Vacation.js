function vacay (count, type, day) {
    let sum = 0;

    if (type === "Students") {
        if (day === "Friday") {
            sum = count * 8.45;
        } else if (day === "Saturday") {
            sum = count * 9.8;
        } else if (day === "Sunday") {
            sum = count * 10.46;
        }

        if (count >= 30) {
            sum -= sum * 0.15; 
        }
    } else if (type === "Business") {
        if (count >= 100) {
            count -= 10;
        }

        if (day === "Friday") {
            sum = count * 10.9;
        } else if (day === "Saturday") {
            sum = count * 15.6;
        } else if (day === "Sunday") {
            sum = count * 16;
        }
    } else if (type === "Regular") {
        if (day === "Friday") {
            sum = count * 15;
        } else if (day === "Saturday") {
            sum = count * 20;
        } else if (day === "Sunday") {
            sum = count * 22.5;
        }

        if (count >= 10 && count <= 20) {
            sum -= sum * 0.05;
        }
    }
    
    console.log(`Total price: ${sum.toFixed(2)}`);
}

// Second way:
//function vacay (count, type, day) {
//    const prices = {
//        Students: {
//            Friday: 8.45,
//            Saturday: 9.8,
//            Sunday: 10.46,
//        },
//        Business: {
//            Friday: 10.9,
//            Saturday: 15.6,
//            Sunday: 16,
//        },
//        Regular: {
//            Friday: 15,
//            Saturday: 20,
//            Sunday: 22.5,
//        },
//    };
//    let sum = 0;
//    const cost = prices [type][day];
//
//    sum = count * cost;
//
//    if (type === "Students" && count >= 30) {
//        sum -= sum * 0.15;
//    }
//
//    if (type === "Business" && count >= 100) {
//        count -= 10;
//    }
//
//    if (type === "Reguar" && count >= 10 && count <= 20) {
//        sum -= sum * 0.05;
//    }
//
//    console.log(`Total price: ${sum.toFixed(2)}`);
//}

vacay(40,"Regular","Saturday");