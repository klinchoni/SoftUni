function solve(input) {
    const parking = new Set();
  
    input.forEach((entry) => {
      const [command, number] = entry.split(", ");
  
      if (command === "IN") {
        parking.add(number);
      } else if (command === "OUT") {
        parking.delete(number);
      }
    });
  
    const carNumbers = Array.from(parking).sort();
  
    console.log(carNumbers);
  }

  // SECOND WAY:
  function solve(input) {
    const parking = [];

    input.forEach((entry) => { 
        const [command, number] = entry.split(", ");

        if(command === "IN") {
            parking.push(number);
        } else if(command === "OUT") {
            const index = parking.indexOf(number);
            parking.splice(index, 1);
        }
    });

    parking.sort();

    console.log(parking);
  }

  // JUDGE 100/100
  function piccolo(parkingLot) {
    class Parking {
      constructor() {
        this.cars = new Set();
      }
      enter(carNumber) {
        this.cars.add(carNumber);
      }
      exit(carNumber) {
        this.cars.delete(carNumber);
      }
      printCars() {
        this.cars.size === 0
          ? console.log("Parking Lot is Empty")
          : Array.from(this.cars)
              .sort()
              .forEach((carNumber) => {
                console.log(carNumber);
              });
      }
    }
    const parking = new Parking();
  
    parkingLot.forEach((entry) => {
      const [direction, carNumber] = entry.split(", ");
      direction === "IN" ? parking.enter(carNumber) : parking.exit(carNumber);
    });
  
    parking.printCars();
  }

 //piccolo([
 //  "IN, CA2844AA",
 //  "IN, CA1234TA",
 //  "OUT, CA2844AA",
 //  "IN, CA9999TT",
 //  "IN, CA2866HI",
 //  "OUT, CA1234TA",
 //  "IN, CA2844AA",
 //  "OUT, CA2866HI",
 //  "IN, CA9876HH",
 //  "IN, CA2822UU",
 //]);
  // JUDGE 100/100
  function solve(input) {
    let parking = [];
    input.forEach((element) => {
      let [direction, carNumber] = element.split(", ");
      if (direction === "IN") {
        if (!parking.includes(carNumber)) {
          parking.push(carNumber);
        }
      } else if (direction === "OUT") {
        if (parking.includes(carNumber)) {
          let car = parking.indexOf(carNumber);
          parking.splice(car, 1);
        }
      }
    });
    
    if (parking.length === 0) {
      console.log("Parking Lot is Empty");
    } else {
      console.log(parking.sort().join("\n"));
    }
  }

  solve([
    "IN, CA2844AA",
    "IN, CA1234TA",
    "OUT, CA2844AA",
    "IN, CA9999TT",
    "IN, CA2866HI",
    "OUT, CA1234TA",
    "IN, CA2844AA",
    "OUT, CA2866HI",
    "IN, CA9876HH",
    "IN, CA2822UU",
  ]);