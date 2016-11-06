app.service("creativeService", function ($http) {

    this.createCreative = function (creative) {
        var creative = {
            Name: creative.Name,
            Tags: creative.Tags,
            Rank: 0,
            Count: 0
        }

        $.post("/Creative/Create/", creative, function (response) {
            creative.Id = response;
            //notes.push(note);
            //callback();
        });
    };



});