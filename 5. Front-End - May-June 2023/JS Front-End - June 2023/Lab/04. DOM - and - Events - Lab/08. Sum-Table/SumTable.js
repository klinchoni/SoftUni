// FIRST WAY:
function sumTable() {
     const prices = Array.from(
        document.querySelectorAll("td:nth-child(2):not(#sum)")
     );
     const total = prices.reduce((acc, curr) => {
        return acc + Number(curr.textContent);
     }, 0);

     document.querySelector("#sum").textContent = total;
}

// SECOND WAY:
//function sumTable() {
//    const prices = Array.from(
//       document.querySelectorAll("td:nth-child(2)"));
//       // remove last element because it will hold the sum
//       prices.pop();
//    const total = prices.reduce((acc, curr) => {
//       return acc + Number(curr.textContent);
//    }, 0);
//
//    document.querySelector("#sum").textContent = total;
//}

// THIRD WAY:
//function sumTable() {
//    const prices = Array.from(
//       document.querySelectorAll("td:nth-child(2)"));
//    console.log(prices);
//    const total = prices
//    .filter((price) => price.id !== "sum")
//    .reduce((acc, curr) => {
//       return acc + Number(curr.textContent);
//    }, 0);
//
//    document.querySelector("#sum").textContent = total;
//}