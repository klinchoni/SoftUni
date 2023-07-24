// FIRST WAY:

function getInfo() {
    const busStopID = document.querySelector("#stopId").value;
    const list = document.querySelector("ul");
    const stopName = document.querySelector("#stopName");

    list.innerHTML = "";

    fetch(`https://localhost:3030/jsonstore/bus/businfo/${busStopID}`)
     .then((res) => res.json())
     .then((busStop) => {
        stopName.textContent = busStop.name;

        Object.entries(busStop.buses).map(([busNumber, timeInMinutes]) => {
            const item = document.createElement("li");
            item.textContent = `Bus ${busNumber} arrives in ${timeInMinutes} minutes`;

            list.appendChild(item);
        });
     })
     .catch(() => {
        stopName.textContent = "Error";
     });
}

// SECOND WAY:

function getInfo() {
    const busStopID = document.querySelector("#stopId").value;
    const list = document.querySelector("ul");
    const stopName = document.querySelector("#stopName");

    list.innerHTML = "";

    const service = {
        busInfoURL: (ID) => `https://localhost:3030/jsonstore/bus/businfo/${ID}`,
    };

    fetch(service.busInfoURL(busStopID))
     .then((res) => res.json())
     .then((busStop) => {
        stopName.textContent = busStop.name;

        Object.entries(busStop.buses).map(([busNumber, timeInMinutes]) => {
            const item = document.createElement("li");
            item.textContent = `Bus ${busNumber} arrives in ${timeInMinutes} minutes`;

            list.appendChild(item);
        });
     })
     .catch(() => {
        stopName.textContent = "Error";
     });
}

// THIRD WAY: 

async function getInfo() {
    const busStopID = document.querySelector("#stopId").value;
    const stopName = document.querySelector("#stopName");
    const list = document.querySelector("#buses");
  
    list.innerHTML = "";
  
    const servece = {
      busInfoURL: (ID) => `http://localhost:3030/jsonstore/bus/businfo/${ID}`,
    };
  
    let busStopInfo;
  
    try {
      const response = await fetch(servece.busInfoURL(busStopID));
      busStopInfo = await response.json();
    } catch (e) {
      stopName.textContent = "Error";
    }
    stopName.textContent = busStopInfo.name;
  
    Object.entries(busStopInfo.buses).map(([busNumber, timeInMinutes]) => {
      const item = document.createElement("li");
      item.textContent = `Bus ${busNumber} arrives in ${timeInMinutes} minutes`;
  
      list.appendChild(item);
    });
  }
