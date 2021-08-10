
const weatherForm = document.getElementById('weather-form');
const weatherContainer = document.getElementById('weather-data-container');

weatherForm?.addEventListener('submit', (e) => {
  e.preventDefault();

  weatherContainer.textContent = 'Klickade på knappen!';
});
