function rotateArray (arr, rotation) {

    for (let i = 0; i < rotation; i++) {
        arr.push(arr.shift());
    }

    console.log(arr.join(' '));
}

rotateArray([32, 21, 61, 1], 4);