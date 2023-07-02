function palindormeIntegers(params) {

    for (let i = 0; i < params.length; i++) {
      const element = String(params[i]);
      
      if (element[0] === element[element.length - 1]) {
        console.log(true);
      } else {
        console.log(false);
      }
    }
  }

  palindormeIntegers([123, 232, 421, 121]);