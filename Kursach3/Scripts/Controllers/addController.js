app.controller('addController', function ($scope, $http) {
    $scope.modalShown = false;
    $scope.toggleModal = function () {
        $scope.modalShown = !$scope.modalShown;
    };
    $scope.modal2Shown = false;
    $scope.toggle2Modal = function(){
        $scope.modal2Shown = !$scope.modalShown;
    };
    $scope.hideModal = function () {
        $scope.modalShown = false;
    };

    $scope.creative = {
        Name: null,
        ChapterView: []
    };

    $scope.ChapterView = {
        Name: null,
        Text: null,
        Tags: []
    };

    $scope.tag = {
        Name: null
    };

    $scope.tags = [];
    $scope.Tags = [];

    $scope.addTag = function () {
        if (this.tagText.length != 0) {
            $scope.tags.push({
                Name: this.tagText
            });
            $scope.Tags.push({
                Name: this.tagText
            });
            this.tagText = '';
        }
    };

    $scope.removeTag = function (tagId) {
        if ($scope.tags.length != 0) {
            $scope.tags.splice(tagId, 1);
        }
    }

    $scope.Chapters = [];

    $scope.addChapter = function () {
        if ($scope.ChapterView.Name.length != 0) {
            $scope.Chapters.push({
                Name: $scope.ChapterView.Name,
                Text: $('#summernote').summernote('code'),
                Tags: $scope.Tags
            });
            $scope.ChapterView = {
                Name: null,
                Text: null
            };
            $scope.tags = [];
            $scope.Tags = [];
        }
    };

    $scope.createCreative = function () {
        $scope.creative = {
            Name: $scope.creative.Name,
            Chapters: $scope.Chapters
        };
        console.log($scope.creative);
        $http.post("/UserPage/Create/", $scope.creative).then(function () { });
        $scope.Chapters = [];
        $scope.creative = {
            Name: '',
            Chapters: []
        };
    };

   
});
