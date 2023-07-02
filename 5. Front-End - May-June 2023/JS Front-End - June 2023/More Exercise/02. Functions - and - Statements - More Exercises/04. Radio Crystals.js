function washChunk(chunk) {
    console.log("Transporting and washing");
    return Math.floor(chunk);
  }
  
  function solve(input) {
    const [target, ...chunks] = input;
  
    const canCut = (chunk) => chunk / 4 >= target;
    const cut = (chunk) => chunk / 4;
  
    for (let chunk of chunks) {
      while (chunk > target) {
        // Cut...
        if (canCut(chunk)) {
          let counter = 0;
  
          while (canCut(chunk)) {
            chunk = cut(chunk);
            counter++;
          }
  
          console.log(`Cut x${counter}`);
          chunk = washChunk(chunk);
        }
  
        // Lap...
        if (chunk - chunk * 0.2 >= target) {
          let counter = 0;
  
          while (chunk - chunk * 0.2 >= target) {
            chunk -= chunk * 0.2;
            counter++;
          }
  
          console.log(`Lap x${counter}`);
          chunk = washChunk(chunk);
        }
  
        // Grind...
        if (chunk - 20 >= target) {
          let counter = 0;
  
          while (chunk - 20 >= target) {
            chunk -= 20;
            counter++;
          }
  
          console.log(`Grind x${counter}`);
          chunk = washChunk(chunk);
        }
  
        // Etch...
        if (chunk - 2 >= target - 1) {
          let counter = 0;
  
          while (chunk - 2 >= target - 1) {
            chunk -= 2;
            counter++;
          }
  
          console.log(`Etch x${counter}`);
          chunk = washChunk(chunk);
        }
      }
  
      if (chunk + 1 === target) {
        chunk += 1;
        console.log("X-ray x1");
      }
  
      console.log(`Finished crystal ${target} microns`);
    }
  }
  
  solve([1375, 50000]);

  // Second way (100/100 in Judge):

//  function crystal(list) {
//    let neededThickness = list[0];
//    for(let i = 1; i < list.length; i++) {
//        let currThickness = list[i];
//
//        console.log(`Processing chunk ${currThickness} microns`);
//
//        let cut = (number) => number / 4;
//        let lap = (number) => number - number * 0.2;
//        let grind = (number) => number - 20;
//        let etch = (number) => number - 2;
//        let xray = (number) => number + 1;
//
//        let cutCount = 0;
//        let lapCount = 0;
//        let grindCount = 0;
//        let etchCount = 0;
//
//        while(currThickness !== neededThickness) {
//            
//            //Cut...
//            while(currThickness / 4 >= neededThickness) {
//                currThickness = cut(currThickness);
//                cutCount++;
//            }
//            if(cutCount > 0) {
//                console.log(`Cut x${cutCount}`);
//                console.log(`Transporting and washing`);
//                currThickness = Math.floor(currThickness);
//            }
//
//            //Lap...
//            while(currThickness - currThickness * 0.2 >= neededThickness) {
//                currThickness = lap(currThickness);
//                lapCount++;
//            }
//            if(lapCount > 0){
//                console.log(`Lap x${lapCount}`);
//                console.log(`Transporting and washing`);
//                currThickness = Math.floor(currThickness);
//            }
//
//            //Grind...
//            while(currThickness - 20 >= neededThickness) {
//                currThickness = grind(currThickness);
//                grindCount++;
//            }
//            if(grindCount > 0) {
//                console.log(`Grind x${grindCount}`);
//                console.log(`Transporting and washing`);
//                currThickness = Math.floor(currThickness);
//            }
//
//            //Etch...
//            while(currThickness - 2 >= neededThickness) {
//                currThickness = etch(currThickness);
//                etchCount++;
//            }
//            if(etchCount > 0) {
//                console.log(`Etch x${etchCount}`);
//                console.log(`Transporting and washing`);
//                currThickness = Math.floor(currThickness);
//            }
//
//            //X-ray...
//            if(currThickness < neededThickness) {
//                currThickness = xray(currThickness);
//                console.log(`X-ray x1`);
//            }
//        }
//        console.log(`Finished crystal ${neededThickness} microns`);
//    }
//}
//
//crystal([1375, 50000]); 
//
//crystal([1000, 4000, 8100] );