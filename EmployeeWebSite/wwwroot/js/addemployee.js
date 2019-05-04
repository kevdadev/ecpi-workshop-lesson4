function AddNewEmployee() {
    var form = $('#addemployeeform');
    var url = form.attr('action');

    $.ajax({
           type: "POST",
           url: url,
           data: form.serialize(),
           success: function(data)
           {
            $('#tblEmployees').empty();
               $.each(data, function(i, v) {
                  $('#tblEmployees').append('<tr><td>' + v.firstName + '</td><td>' + v.lastName + '</td><td>' + v.emailAddress + '</td><td>' + v.dateOfBirth + '</td><td>' + v.phoneNumber+ '</td></tr>')
               });
           }
    });
}

 