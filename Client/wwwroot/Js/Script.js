window.JsFunctions = {
    ShowModal: function (modalId) {
        $('#' + modalId).modal('show');
    },
    CloseModal: function (modalId) {
        $('#' + modalId).modal('hide');
    },

    saveAsFile: function (filename, bytesBase64) {
    if (navigator.msSaveBlob) {
        //Download document in Edge browser
        var data = window.atob(bytesBase64);
        var bytes = new Uint8Array(data.length);
        for (var i = 0; i < data.length; i++) {
            bytes[i] = data.charCodeAt(i);
        }
        var blob = new Blob([bytes.buffer], { type: "application/octet-stream" });
        navigator.msSaveBlob(blob, filename);
    }
    else {
        var link = document.createElement('a');
        link.download = filename;
        link.href = "data:application/octet-stream;base64," + bytesBase64;
        document.body.appendChild(link); // Needed for Firefox
        link.click();
        document.body.removeChild(link);
    }
    },
    
    initialize: function () {
        let latlng = new google.maps.LatLng(36.1854234, 5.424118);
        let options = {
            zoom: 10, center: latlng,
            mapTypeId: google.maps.MapTypeId.ROADMAP
        };
        let map = new google.maps.Map(document.getElementById("map"), options);
    },

    geocodeAddress: function (address) {
        geocoder = new google.maps.Geocoder();
        var myPromise = new Promise((resolve, reject) => {
        geocoder.geocode({ 'address': address }, function (results, status) {
            if (status == 'OK') {
                let map = new google.maps.Map(document.getElementById("map"), {
                    zoom: 18
                });
                map.setCenter(results[0].geometry.location);
                var marker = new google.maps.Marker({
                    map: map,
                    position: results[0].geometry.location
                });
                console.log(results[0].geometry.location.toJSON());
                let geoLocation =  results[0].geometry.location.toJSON() 
                resolve(geoLocation);
            }
            error => { reject(error) }
            //} else {
            //    alert('Geocode was not successful for the following reason: ' + status);
            //}
        });
        }).catch(error => error);
        return myPromise;
    },

    assemblyname: "Blazored.Typeahead",
    setFocus: (element) => {
        element.focus();
    },
    // No need to remove the event listeners later, the browser will clean this up automagically.
    addKeyDownEventListener: (element) => {
        element.addEventListener('keydown', (event) => {
            const key = event.key;

            if (key === "Enter") {
                event.preventDefault();
            }
        });
    },
};


$(document).ready(function () {
    // Main Template Color
    var brandPrimary = '#33b35a';

    //$('[data-toggle="tooltip"]').tooltip();

    // ------------------------------------------------------- //
    // Universal Form Validation
    // ------------------------------------------------------ //

    $('.form-validate').each(function () {
        $(this).validate({
            errorElement: "div",
            errorClass: 'is-invalid',
            validClass: 'is-valid',
            ignore: ':hidden:not(.summernote),.note-editable.card-block',
            errorPlacement: function (error, element) {
                // Add the `invalid-feedback` class to the error element
                error.addClass("invalid-feedback");
                //console.log(element);
                if (element.prop("type") === "checkbox") {
                    error.insertAfter(element.siblings("label"));
                }
                else {
                    error.insertAfter(element);
                }
            }
        });
    });
    // ------------------------------------------------------- //
    // Material Inputs
    // ------------------------------------------------------ //

    var materialInputs = $('input.input-material');

    // activate labels for prefilled values
    materialInputs.filter(function () {
        return $(this).val() !== "";
    }).siblings('.label-material').addClass('active');

    // move label on focus
    materialInputs.on('focus', function () {
        $(this).siblings('.label-material').addClass('active');
    });

    // remove/keep label on blur
    materialInputs.on('blur', function () {
        $(this).siblings('.label-material').removeClass('active');

        if ($(this).val() !== '') {
            $(this).siblings('.label-material').addClass('active');
        } else {
            $(this).siblings('.label-material').removeClass('active');
        }
    });

    // ------------------------------------------------------- //
    // Jquery Progress Circle
    // ------------------------------------------------------ //
    //var progress_circle = $("#progress-circle").gmpc({
    //    color: brandPrimary,
    //    line_width: 5,
    //    percent: 80
    //});
    //progress_circle.gmpc('animate', 80, 3000);

    // ------------------------------------------------------- //
    // External links to new window
    // ------------------------------------------------------ //

    $('.external').on('click', function (e) {

        e.preventDefault();
        window.open($(this).attr("href"));
    });

    // ------------------------------------------------------ //
    // For demo purposes, can be deleted
    // ------------------------------------------------------ //

    var stylesheet = $('link#theme-stylesheet');
    $("<link id='new-stylesheet' rel='stylesheet'>").insertAfter(stylesheet);
    var alternateColour = $('link#new-stylesheet');

    //if ($.cookie("theme_csspath")) {
    //    alternateColour.attr("href", $.cookie("theme_csspath"));
    //}

    $("#colour").change(function () {

        if ($(this).val() !== '') {

            var theme_csspath = 'css/style.' + $(this).val() + '.css';

            alternateColour.attr("href", theme_csspath);

            $.cookie("theme_csspath", theme_csspath, {
                expires: 365,
                path: document.URL.substr(0, document.URL.lastIndexOf('/'))
            });

        }

        return false;
    });
});


function toggleNavBar() {
    var x = document.getElementById("exampledropdownDropdown");
    if (x.style.display === "block") {
        x.style.display = "none";
    } else {
        x.style.display = "block";
    }
}

function toggleSidBar() {
    if ($(window).outerWidth() > 1194) {
        $('nav.side-navbar').toggleClass('shrink');
        $('.page').toggleClass('active');
    } else {
        $('nav.side-navbar').toggleClass('show-sm');
        $('.page').toggleClass('active-sm');
    }
    
    if (400 > $(window).outerWidth()) {
        $('#Deco span').toggleClass('hide');
        $('.fa-sign-out').toggleClass('fo');
    }
}

function labelfocus() {
    materialInputs.on('focus', function () {
        $(this).siblings('.label-material').addClass('active');
    });
}

