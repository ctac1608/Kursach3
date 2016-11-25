app.controller("userDataController", function ($scope, userPageService) {

    userPageService.getUser($scope);

});