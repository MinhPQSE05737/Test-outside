$(function () {
    //
    let listgroup = document.getElementById("list-group");
    let itemactions = listgroup.getElementsByClassName("list-group-item-action");
    for (let i = 0; i < itemactions.length; i++) {
        itemactions[i].addEventListener("click", function () {
            let current = document.getElementsByClassName("active");
            current[0].className = current[0].className.replace(" active", "");
            this.className += " active";
        });
    }

    //When click tab home
    $(".home").click(function () {
        $(".listContent").text("Đây là nội dung chính của trang web");
    });
    //When click tab Products
    $(".listProducts").click(function () {

        $.ajax({
            type: "GET",
            url: "/Home/GetAllDataFromDB",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {
                $(".listContent").empty();

                let row;
                for (let i = 0; i < data.length; i++) {
                    row += "<tr><td>" + data[i].id + "</td><td>" + data[i].name + "</td><td>" + data[i].age + "</td></tr>";
                }
                $(".listContent").append(row);
            },
            error: function (r) {
                alert(r.responseText);
            },
        });
    });

});

//Responsive navigation menu
function myFunction() {
    let x = document.getElementById("list-group");
    let y = x.parentElement.className;
    
    console.log(y);
    if (x.className === "topnav") {
        x.className += " responsive";
        
    } else {
        x.className = "topnav";
        $(".listGroup").hide();
    }
}
//function navSlide() {
//    const burger = document.querySelector(".burger");
//    const nav = document.querySelector(".nav-links");

//    burger.addEventListener('click', () => {
//        nav.classList.toggle('active');
//    });
//}

//open navigation
function openNav() {
    document.getElementById("mySidenav").style.width = "150px";
}
//close navigation
function closeNav() {
    document.getElementById("mySidenav").style.width = "0";
}

//When user enter text into textbox
function runScript(e) {
    let toEmail = $(".textboxEmail").val(); //check value textbox
    let subject = "Thư chúc mừng";
    let body = "Chúc mừng bạn đến với công ty chúng tôi";

    //if key is Enter
    if (e.keyCode == 13) {
        if (toEmail === "") {
            alert("Please enter email!!!");
            return;
        }

        if (validateEmail(toEmail)) {
            let data = {
                toEmail: toEmail,
                subject: subject,
                body: body
            }
            $.ajax({
                type: "POST",
                url: "/Home/SendMail",
                data: JSON.stringify(data),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (r) {
                    alert(r.d);
                },
                error: function (r) {
                    alert(r.responseText);
                },
            });
        } else {
            alert(toEmail + " is not valid :(");
            return false;
        }


    }
}

//validate email
function validateEmail(email) {
    //regex check email
    const re = /^(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
    return re.test(email);
}



