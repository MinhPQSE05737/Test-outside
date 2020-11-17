
function runScript(e) {
        let toEmail = $(".textboxEmail").val(); //check value textbox
        let subject = "Thư chúc mừng";
        let body = "Chúc mừng bạn đến với công ty chúng tôi";

    //if key is Enter
    if (e.keyCode == 13) {
            
           
        if (validateEmail(toEmail)) {
            $.ajax({
                type: "POST",
                url: "Main/SendEmail",
                data: "{ toEmail: '" + toEmail + "', subject: '" + subject + "', body: '" + body + "' }",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (r) {
                    alert(r.d);
                },
                error: function (r) {
                    alert(r.responseText);
                },
                failure: function (r) {
                    alert(r.responseText);
                }
            });
        } else {
            alert(toEmail + " is not valid :(");
            return false;
        }
        
           
    }
}

function validateEmail(email) {
    //regex check email
    const re = /^(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
    return re.test(email);
}
