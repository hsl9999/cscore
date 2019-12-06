namespace com.csutil {

    public interface IAppFlow {
        void TrackEvent(string category, string action, params object[] args);
    }

    public class AppFlow {

        public const string catMethod = "method";
        public const string catError = "error";
        public const string catMutation = "mutation";

        public const string catUi = "ui";
        public const string catPrefab = "prefab";
        public const string catLinked = "linked";
        public const string catView = "view";
        public const string catPresenter = "presenter";

        public static IAppFlow instance;

        public static void TrackEvent(string category, string action, params object[] args) {
            instance?.TrackEvent(category, action, args);
        }

    }

}