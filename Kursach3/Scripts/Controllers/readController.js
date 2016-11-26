app.controller('readController', function ($scope, $http) {

    $scope.creative = {
        Id: null,
        Name: null,
        Chapters: []
    };

    $scope.Chapters = [];
    
    $scope.Chapter = {
        Id: null,
        Name: null,
        Position: null,
        Tags: []
    };

    $scope.Tags = [];

    $scope.Tag = {
        Id: null,
        Name: null,
        ChapterId: null
    };

    $http.get("/Creative/GetCreative/").then(function (response) {
        $scope.creative = response.data;
    });


});