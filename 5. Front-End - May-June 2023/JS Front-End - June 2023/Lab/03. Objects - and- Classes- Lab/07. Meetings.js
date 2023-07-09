function meetings(array) {
    const schedule = array.reduce((acc, curr) => {
      const [weekday, name] = curr.split(" ");
  
      if (acc.hasOwnProperty(weekday)) {
        console.log(`Conflict on ${weekday}!`);
      } else {
        acc[weekday] = name;
        console.log(`Scheduled for ${weekday}`);
      }
      return acc;
    }, {});

    Object.entries(schedule).forEach(([weekday, name]) => {
      console.log(`${weekday} -> ${name}`);
    });
  }
  
  meetings([
  'Monday Peter',
  'Wednesday Bill',
  'Monday Tim',
  'Friday Tim'
  ]);
  
  meetings([
    "Friday Bob",
    "Saturday Ted",
    "Monday Bill",
    "Monday John",
    "Wednesday George",
  ]);