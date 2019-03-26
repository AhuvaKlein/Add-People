$(() => {
    console.log('hello world');

    let personNumber = 0;

    $("#AddPerson").on("click", function () {
        personNumber++;
        $("#FormInputs").append(`</br><input type="text" placeholder="First Name" name="people[${personNumber}].FirstName" class="form-control" />
            <input type="text" placeholder="Last Name" name="people[${personNumber}].LastName" class="form-control" />
            <input type="text" placeholder="Age" name="people[${personNumber}].Age" class="form-control"/>`)
    });


});