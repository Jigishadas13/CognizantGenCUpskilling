// Welcome Message

console.log("Welcome to the Community Portal");

window.onload = function () {

    alert("Page Fully Loaded");

    loadPreference();

    displayEvents();
};

// Event Data

const events = [

    {
        name: "Music Festival",
        category: "Music",
        seats: 50,
        image: "images/music.jpg"
    },

    {
         name: "Sports Meet",
        category: "Sports",
        seats: 30,
        image: "images/sports.jpeg"
    },

    {
        name: "Dance Show",
        category: "Dance",
        seats: 40,
        image: "images/dance.jpeg"
    }

];

// Display Events

function displayEvents() {

    const container =
        document.querySelector("#eventContainer");

    container.innerHTML = "";

    events.forEach(event => {

        const card =
            document.createElement("div");

        card.classList.add("eventCard");

        card.innerHTML = `

<div class="eventBadge">
    Trending
</div>

<img src="${event.image}"
     alt="${event.name}">

<div class="eventContent">

    <h3>${event.name}</h3>

    <p>
        Category: ${event.category}
    </p>

    <p>
        Seats Available: ${event.seats}
    </p>

    <button onclick="registerEvent('${event.name}')">

        Register Now

    </button>

</div>
`;

        container.appendChild(card);
    });
}

// Register Event

function registerEvent(eventName) {

    try {

        const event =
            events.find(e => e.name === eventName);

        if (event.seats <= 0) {
            throw "No Seats Available";
        }

        event.seats--;

        alert("Registered for " + eventName);

        displayEvents();

    }
    catch (error) {

        alert(error);
    }
}

// Registration Form

document.getElementById("registrationForm")
.addEventListener("submit", function (event) {

    event.preventDefault();

    document.getElementById("msg")
    .innerHTML = "Registration Successful!";
});

// Validate Phone

function validatePhone() {

    let phone =
        document.getElementById("phone").value;

    if (phone.length != 10) {

        alert("Phone number must be 10 digits");
    }
}

// Show Fee

function showFee(value) {

    document.getElementById("fee")
    .innerHTML = "Event Fee: ₹" + value;
}

// Enlarge Image

function enlarge(img) {

    img.style.width = "400px";
}

// Character Counter

function countChars(text) {

    document.getElementById("count")
    .innerHTML =
    "Characters: " + text.value.length;
}

// Video Ready

function videoReady() {

    document.getElementById("videoMsg")
    .innerHTML =
    "Video Ready To Play";
}

// Warning Message

function warningMessage() {

    return "Your form is not completed!";
}

// Local Storage

function loadPreference() {

    let saved =
        localStorage.getItem("preferredEvent");

    if (saved) {

        document.getElementById("eventType").value =
        saved;
    }
}

document.getElementById("eventType")
.addEventListener("change", function () {

    localStorage.setItem(
        "preferredEvent",
        this.value
    );
});

// Clear Data

function clearData() {

    localStorage.clear();

    sessionStorage.clear();

    alert("Preferences Cleared");
}

// Geolocation

function findLocation() {

    if (navigator.geolocation) {

        navigator.geolocation.getCurrentPosition(

            success,

            error,

            {
                enableHighAccuracy: true,
                timeout: 5000
            }
        );
    }
}

// Success

function success(position) {

    let lat = position.coords.latitude;

    let lon = position.coords.longitude;

    document.getElementById("location")
    .innerHTML =

        `Latitude: ${lat}
         <br>
         Longitude: ${lon}`;
}

// Error

function error(err) {

    if (err.code == 1) {

        alert("Permission Denied");
    }

    else if (err.code == 3) {

        alert("Request Timeout");
    }
}