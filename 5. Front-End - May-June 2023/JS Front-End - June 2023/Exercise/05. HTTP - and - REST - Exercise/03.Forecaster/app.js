function attachEvents() {
    const baseURL = "http://localhost:3030/jsonstore/forecaster/";
    const location = document.querySelector("#location");
  
    document.querySelector("#submit").addEventListener("click", onClick);
    const forecastDiv = document.querySelector("#forecast");
    const currentForecast = document.querySelector("#current");
    const mainDivUpcoming = document.querySelector("#upcoming");
  
    const forecastIcons = {
      Sunny: "&#x2600;",
      "Partly sunny": "&#x26C5;",
      Overcast: "&#x2601;",
      Rain: "&#x2614;",
      Degrees: "&#176;",
    };
  
    //create div with class forecast
    createDiv("divForecast", currentForecast, "forecasts");
  
    //create div with class forecast-info
    createDiv("divForecastInfo", mainDivUpcoming, "forecast-info");
  
    function onClick() {
      let currentLocationCode = "";
  
      document.querySelector(".forecasts").remove();
      document.querySelector(".forecast-info").remove();
  
      fetch(`${baseURL}locations`)
        .then((response) => {
          return response.json();
        })
        .then((cityData) => {
          for (const elem of cityData) {
            if (elem.name === location.value) {
              currentLocationCode = elem.code;
              break;
            }
          }
  
          fetch(`${baseURL}today/${currentLocationCode}`)
            .then((response) => {
              if (response.ok) {
                return response.json();
              }
            })
            .then((forecastDataToday) => {
              let { name, forecast } = forecastDataToday;
              forecastDiv.style.display = "block";
  
              //create div with class forecast
              let divForecast = document.createElement("div");
              divForecast.className = "forecasts";
              currentForecast.appendChild(divForecast);
  
              //crate span conditional symbol
              let spanConditionalSymbol = document.createElement("span");
              spanConditionalSymbol.className = "condition symbol";
              spanConditionalSymbol.innerHTML =
                forecastIcons[forecast["condition"]];
              divForecast.appendChild(spanConditionalSymbol);
  
              //create span main condition
              let spanMain = document.createElement("span");
              spanMain.className = "condition";
              divForecast.appendChild(spanMain);
  
              //create spans forecast - data
              let spanForecastName = document.createElement("span");
              spanForecastName.className = "forecast-data";
              spanForecastName.innerHTML = name;
              spanMain.appendChild(spanForecastName);
  
              let spanForecastTemp = document.createElement("span");
              spanForecastTemp.className = "forecast-data";
              spanForecastTemp.innerHTML = `${forecast.low}${forecastIcons.Degrees}/${forecast.high}${forecastIcons.Degrees}`;
              spanMain.appendChild(spanForecastTemp);
  
              let spanForecastDescription = document.createElement("span");
              spanForecastDescription.className = "forecast-data";
              spanForecastDescription.innerHTML = forecast.condition;
              spanMain.appendChild(spanForecastDescription);
            })
            .catch((error) => catchError());
          fetch(`${baseURL}upcoming/${currentLocationCode}`)
            .then((response) => {
              if (response.ok) {
                return response.json();
              }
            })
            .then((forecastDataUpcoming) => {
              //create div with class forecast-info
              let divForecastInfo = document.createElement("div");
              divForecastInfo.className = "forecast-info";
              mainDivUpcoming.appendChild(divForecastInfo);
  
              forecastDataUpcoming.forecast.forEach((dayForecast) => {
                let { low, high, condition } = dayForecast;
  
                //create main span upcoming
                let mainSpan = document.createElement("span");
                mainSpan.className = "upcoming";
                divForecastInfo.appendChild(mainSpan);
  
                //create spans forecast - data
                let spanSymbol = document.createElement("span");
                spanSymbol.className = "symbol";
                spanSymbol.innerHTML = forecastIcons[condition];
                divForecastInfo.appendChild(spanSymbol);
  
                let spanForecastTemp = document.createElement("span");
                spanForecastTemp.className = "forecast-data";
                spanForecastTemp.innerHTML = `${low}${forecastIcons.Degrees}/${high}${forecastIcons.Degrees}`;
                divForecastInfo.appendChild(spanForecastTemp);
  
                let spanForecastDescription = document.createElement("span");
                spanForecastDescription.className = "forecast-data";
                spanForecastDescription.innerHTML = condition;
                divForecastInfo.appendChild(spanForecastDescription);
  
                mainSpan.appendChild(spanSymbol);
                mainSpan.appendChild(spanForecastTemp);
                mainSpan.appendChild(spanForecastDescription);
              });
            })
            .catch((error) => catchError());
        })
        .catch((error) => catchError());
    }
    function catchError() {
      const forecastDiv = document.getElementById("forecast");
      forecastDiv.style.display = "block";
      forecastDiv.textContent = "Error";
    }
  }
  function createDiv(name, parentNme, clasName) {
    name = document.createElement("div");
    name.className = clasName;
    parentNme.appendChild(name);
  }

attachEvents();