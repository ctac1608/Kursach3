app.controller('readController', function ($scope, $location, $routeParams, $http) {

    $scope.creative = {
        Id: parseInt($location.absUrl().match(/\d+$/g)),
        Name: null,
        Chapters: []
    };

    $scope.Chapters = [];
    
    $scope.Chapter = {
        Id: null,
        Name: null,
        Text: null,
        Position: null,
        Tags: []
    };

    $scope.Tags = [];

    $scope.Tag = {
        Id: null,
        Name: null,
        ChapterId: null
    };

    


    $http.post("/Creative/GetCreative/", $scope.creative).then(function (response) {
        $scope.creative = response.data;
    });


});