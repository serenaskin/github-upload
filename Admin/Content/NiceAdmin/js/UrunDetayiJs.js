
Dropzone.autoDiscover = false;
$(function () {
    var dz = null;

    $("#mydropzone").dropzone({
        autoProcessQueue: false,
        paramName: "productpictures",
        maxFilesize: 1, //mb
        maxThumbnailFilesize: 1, //mb
        maxFiles: 10,
        parallelUploads: 10,
        acceptedFiles: ".jpeg,.png,.jpg",
        uploadMultiple: true,
        addRemoveLinks: true,
        //resizeWidth:128,
        init: function () {
            dz: this;
            $("#uploadbutton").click(function () {
                dz.processQueue();
            });
        },
        dictDefaultMessage: "Buraya görselleri sürükle-bırak yapabilirsiniz..",
        dictRemoveFile: "Dosyayı sil.."


    });
    //Samet ekledi
    $('#DropzoneRemovePicture').click(function (e) {
        e.preventDefault();
        console.log(e);
        var id = $(e.srcElement).attr("data-id");

        //$.ajax({
        //    url: "/Product/DropzoneDelete",
        //    type: "POST",
        //    data: {id: id},
        //    success: function (data) {
        //        $(`.samet-${id}`).remove();
        //    },
        //    error: function () {

        //    }
        //});

        //e.preventDefault();
    });
});

                        //Yeni



//eN SON Kİ TÜM KODLAR
  //<!-- < img src = "https://localhost:44360/@item.PictureUrl"-- > @* draggable="true" ondragstart = "drag(event)" *@ @* alt="Avatar" *@ < !--style="width:150px" >
  //  <button class="btn btn-danger" onclick="DropzoneRemovePicture(@item.PictureId, this)"><i class="icon_close_alt2"></i></button>
  //  <div id="DropzoneId" class="samet-@item.PictureId">-->


  //      function DropzoneRemovePicture(id) {
  //          $.ajax({
  //              url: "/Product/DropzoneDelete",
  //              type: "POST",
  //              data: { id: id },
  //              success: function (data) {
  //                  $(`.samet-${id}`).remove();
  //              },
  //              error: function () {

  //              }
  //          });
  //      }





//<script>
//        //(27.09.2020)
//        //New Added fordropzone

//    Dropzone.options.myAwesomeDropzone = { // The camelized version of the ID of the form element

//        // The configuration we've talked about above
//        autoProcessQueue: false,
//            uploadMultiple: true,
//            parallelUploads: 100,
//            maxFiles: 100,

//            // The setting up of the dropzone
//            init: function () {
//                var myDropzone = this;

//                // First change the button to actually tell Dropzone to process the queue.
//                this.element.querySelector("button[type=submit]").addEventListener("click", function (e) {
//        // Make sure that the form isn't actually being sent.
//        e.preventDefault();
//                    e.stopPropagation();
//                    myDropzone.processQueue();
//                });

//                // Listen to the sendingmultiple event. In this case, it's the sendingmultiple event instead
//                // of the sending event because uploadMultiple is set to true.
//                this.on("sendingmultiple", function () {
//        // Gets triggered when the form is actually being sent.
//        // Hide the success button or the complete form.
//    });
//                this.on("successmultiple", function (files, response) {
//        // Gets triggered when the files have successfully been sent.
//        // Redirect user or notify of success.
//    });
//                this.on("errormultiple", function (files, response) {
//        // Gets triggered when there was an error sending the files.
//        // Maybe show form again, and notify user of error
//    });
//            }

//        }
//    </script>




//new dropzoe view code 

//@* Dropzone *@
//                                <div class="tab-pane fade" id="nav-contact" role="tabpanel" aria-labelledby="nav-contact-tab">
//    <div class="row">
//        <div class="col-lg-12">

//            @*<div class="form-horizontal">

//                <div class="form-group">
//                    <div class="col-lg-2">Browse Files</div>
//                    <div class="col-md-10">
//                        <input type="file" multiple name="files" id="Files" />
//                    </div>
//                </div>
//                <div class="form-group">
//                    <div class="col-md-offset-2 col-md-10">
//                        <input type="submit" value="Upload" class="btn btn-primary" />
//                    </div>
//                </div>
//                <div class="form-group">
//                    <div class="col-md-offset-2 col-md-10 text-success">
//                        @ViewBag.UploadStatus
//                            </div>
//                </div>

//            </div>*@



//Second
//@* <form action="~/Product/UploadProductImages" method="post" enctype="multipart/form-data" class="dropzone" id="dropzoneForm">
//    <div class="fallback">
//        <input name="file" type="file" multiple />
//        <input type="submit" value="Upload" />
//    </div>
//</form> *@








//@* <div class="form-horizontal">

//    <div class="form-group">
//        <div class="col-lg-2">Browse Files</div>
//        <div class="col-md-10">
//            <input type="file" multiple name="files" id="Files" />
//        </div>
//    </div>
//    <div class="form-group">
//        <div class="col-md-offset-2 col-md-10">
//            <input type="submit" value="Upload" class="btn btn-primary" />
//        </div>
//    </div>
//    <div class="form-group">
//        <div class="col-md-offset-2 col-md-10 text-success">
//            @ViewBag.UploadStatus
//                </div>
//    </div>

//</div> *@


//                                                                    @* Turkcell *@
//                                                                    @* https://gelecegiyazanlar.turkcell.com.tr/konu/web-programlama/egitim/201-html5-css/html5te-surukle-birak-drag-drop*@
//@* <div id="KUTU1" draggable="true" ondragstart="return dragStart(event)">
//    <span class="note needsclick"> Dosyaları <strong>bu alana</strong> sürükleyiniz</span>

//</div>
//    <div id="KUTU2"></div>*@