@Code
    ViewData("Title") = "Home Page"
End Code

    <div class="row">
        <div class="col-md-2">
            <div class="list-group">
                <a href="#" class="list-group-item list-group-item-action active">
                    Home
                </a>
                <a href="#" class="list-group-item list-group-item-action">Intro</a>
                <a href="#" class="list-group-item list-group-item-action">Products</a>
                <a href="#" class="list-group-item list-group-item-action">Links</a>
                <a href="#" class="list-group-item list-group-item-action">About</a>
            </div>
        </div>
        <div class="col-md-7 listContent">
            Đây là nội dung chính của trang web
        </div>
        <div class="col-md-3">
            <div class="box-right" style="border: solid">
                <h5>News letter</h5>
                <input type="text"class="textboxEmail" placeholder="Địa chỉ email..." onkeypress="runScript(event)"/>
            </div>
        </div>
    </div>

 
   

