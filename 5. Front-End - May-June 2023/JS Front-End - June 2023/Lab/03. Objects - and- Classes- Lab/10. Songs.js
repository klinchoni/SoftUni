class Song {
    constructor(type, name, time) {
      this.type = type;
      this.name = name;
      this.time = time;
    }
  }
  
  function printSongs(array) {
    let songs = [];
    array.shift();
    let typeOfSong = array.pop();
  
    for (let i = 0; i < array.length; i++) {
      let [type, name, time] = array[i].split("_");
      let song = new Song(type, name, time);
      songs.push(song);
    }
  
    if (typeOfSong === "all") {
      songs.forEach((songInfo) => console.log(songInfo.name));
    } else {
      let filter = songs.filter((songInfo) => songInfo.type === typeOfSong);
      filter.forEach((songInfo) => console.log(songInfo.name));
    }
  }
  printSongs([
    4,
    "favourite_DownTown_3:14",
    "listenLater_Andalouse_3:24",
    "favourite_In To The Night_3:58",
    "favourite_Live It Up_3:48",
    "listenLater",
  ]);