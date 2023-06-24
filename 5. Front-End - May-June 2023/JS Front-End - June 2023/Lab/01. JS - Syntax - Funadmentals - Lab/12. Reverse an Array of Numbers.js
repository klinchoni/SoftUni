function reverseArray (count, arr) {
    let resultArray = arr.slice(0, count).reverse().join(" ");
    console.log(resultArray);
}

reverseArray(2, [66, 43, 75, 89, 47]);

// Second way:

//function reverseArray (count, arr) {
//    let resultArray = [];
//
//    for (let i=0; i<count; i++) {
//        resultArray.push(arr[i]);
//    }
//
//    console.log(resultArray.reverse().join(" "));
//}

//reverseArray(4, [-1, 20, 99, 5]);