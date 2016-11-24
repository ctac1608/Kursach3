app.controller('addController', function ($scope, $http) {
    $scope.modalShown = false;
    $scope.toggleModal = function () {
        $scope.modalShown = !$scope.modalShown;
    };

    $scope.creative = {
        Name: null
        
    };

    $scope.createCreative = function () {
        console.log($scope.creative);

        var creative = {
            Id: null,
            Name: $scope.creative.Name,
            Rank: null,
            Count: null,
            CreateData: null,
            RedactData: null,
            UserId: null
        };
        
   //     var creative = Object.create(creativee);

        $http.post("/UserPage/Create/", creative).then(function (a) { console.log(a); }, function (a) { console.log(a);});
    };

   
});