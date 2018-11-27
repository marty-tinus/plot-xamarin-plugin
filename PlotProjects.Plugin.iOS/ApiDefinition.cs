using System;
using Foundation;
using ObjCRuntime;
using PlotProjects;
using UIKit;
using UserNotifications;

namespace PlotProjects.Plugin
{
    [Static]
    partial interface Constants
    {
        // extern NSString *const PlotNotificationIdentifier;
        [Field("PlotNotificationIdentifier", "__Internal")]
        NSString PlotNotificationIdentifier { get; }

        // extern NSString *const PlotNotificationMatchIdentifier;
        [Field("PlotNotificationMatchIdentifier", "__Internal")]
        NSString PlotNotificationMatchIdentifier { get; }

        // extern NSString *const PlotNotificationMessage;
        [Field("PlotNotificationMessage", "__Internal")]
        NSString PlotNotificationMessage { get; }

        // extern NSString *const PlotNotificationActionKey;
        [Field("PlotNotificationActionKey", "__Internal")]
        NSString PlotNotificationActionKey { get; }

        // extern NSString *const PlotNotificationDataKey;
        [Field("PlotNotificationDataKey", "__Internal")]
        NSString PlotNotificationDataKey { get; }

        // extern NSString *const PlotNotificationIsAppInForegroundKey;
        [Field("PlotNotificationIsAppInForegroundKey", "__Internal")]
        NSString PlotNotificationIsAppInForegroundKey { get; }

        // extern NSString *const PlotNotificationIsBeacon;
        [Field("PlotNotificationIsBeacon", "__Internal")]
        NSString PlotNotificationIsBeacon { get; }

        // extern NSString *const PlotNotificationTrigger;
        [Field("PlotNotificationTrigger", "__Internal")]
        NSString PlotNotificationTrigger { get; }

        // extern NSString *const PlotNotificationRegionType;
        [Field("PlotNotificationRegionType", "__Internal")]
        NSString PlotNotificationRegionType { get; }

        // extern NSString *const PlotNotificationGeofenceLatitude;
        [Field("PlotNotificationGeofenceLatitude", "__Internal")]
        NSString PlotNotificationGeofenceLatitude { get; }

        // extern NSString *const PlotNotificationGeofenceLongitude;
        [Field("PlotNotificationGeofenceLongitude", "__Internal")]
        NSString PlotNotificationGeofenceLongitude { get; }

        // extern NSString *const PlotNotificationMatchRange;
        [Field("PlotNotificationMatchRange", "__Internal")]
        NSString PlotNotificationMatchRange { get; }

        // extern NSString *const PlotNotificationDwellingMinutes;
        [Field("PlotNotificationDwellingMinutes", "__Internal")]
        NSString PlotNotificationDwellingMinutes { get; }

        // extern NSString *const PlotNotificationTriggerEnter;
        [Field("PlotNotificationTriggerEnter", "__Internal")]
        NSString PlotNotificationTriggerEnter { get; }

        // extern NSString *const PlotNotificationTriggerExit;
        [Field("PlotNotificationTriggerExit", "__Internal")]
        NSString PlotNotificationTriggerExit { get; }

        // extern NSString *const PlotNotificationRegionTypeGeofence;
        [Field("PlotNotificationRegionTypeGeofence", "__Internal")]
        NSString PlotNotificationRegionTypeGeofence { get; }

        // extern NSString *const PlotNotificationRegionTypeBeacon;
        [Field("PlotNotificationRegionTypeBeacon", "__Internal")]
        NSString PlotNotificationRegionTypeBeacon { get; }

        // extern NSString *const PlotNotificationHandlerType;
        [Field("PlotNotificationHandlerType", "__Internal")]
        NSString PlotNotificationHandlerType { get; }

        // extern NSString *const PlotNotificationHandlerTypeRegular;
        [Field("PlotNotificationHandlerTypeRegular", "__Internal")]
        NSString PlotNotificationHandlerTypeRegular { get; }

        // extern NSString *const PlotNotificationHandlerTypeLandingPage;
        [Field("PlotNotificationHandlerTypeLandingPage", "__Internal")]
        NSString PlotNotificationHandlerTypeLandingPage { get; }

        // extern NSString *const PlotNotificationHandlerTypeApplink;
        [Field("PlotNotificationHandlerTypeApplink", "__Internal")]
        NSString PlotNotificationHandlerTypeApplink { get; }

        // extern NSString *const PlotGeotriggerIdentifier;
        [Field("PlotGeotriggerIdentifier", "__Internal")]
        NSString PlotGeotriggerIdentifier { get; }

        // extern NSString *const PlotGeotriggerMatchIdentifier;
        [Field("PlotGeotriggerMatchIdentifier", "__Internal")]
        NSString PlotGeotriggerMatchIdentifier { get; }

        // extern NSString *const PlotGeotriggerName;
        [Field("PlotGeotriggerName", "__Internal")]
        NSString PlotGeotriggerName { get; }

        // extern NSString *const PlotGeotriggerDataKey;
        [Field("PlotGeotriggerDataKey", "__Internal")]
        NSString PlotGeotriggerDataKey { get; }

        // extern NSString *const PlotGeotriggerIsBeacon;
        [Field("PlotGeotriggerIsBeacon", "__Internal")]
        NSString PlotGeotriggerIsBeacon { get; }

        // extern NSString *const PlotGeotriggerTrigger;
        [Field("PlotGeotriggerTrigger", "__Internal")]
        NSString PlotGeotriggerTrigger { get; }

        // extern NSString *const PlotGeotriggerRegionType;
        [Field("PlotGeotriggerRegionType", "__Internal")]
        NSString PlotGeotriggerRegionType { get; }

        // extern NSString *const PlotGeotriggerGeofenceLatitude;
        [Field("PlotGeotriggerGeofenceLatitude", "__Internal")]
        NSString PlotGeotriggerGeofenceLatitude { get; }

        // extern NSString *const PlotGeotriggerGeofenceLongitude;
        [Field("PlotGeotriggerGeofenceLongitude", "__Internal")]
        NSString PlotGeotriggerGeofenceLongitude { get; }

        // extern NSString *const PlotGeotriggerMatchRange;
        [Field("PlotGeotriggerMatchRange", "__Internal")]
        NSString PlotGeotriggerMatchRange { get; }

        // extern NSString *const PlotGeotriggerTriggerEnter;
        [Field("PlotGeotriggerTriggerEnter", "__Internal")]
        NSString PlotGeotriggerTriggerEnter { get; }

        // extern NSString *const PlotGeotriggerTriggerExit;
        [Field("PlotGeotriggerTriggerExit", "__Internal")]
        NSString PlotGeotriggerTriggerExit { get; }

        // extern NSString *const PlotGeotriggerRegionTypeGeofence;
        [Field("PlotGeotriggerRegionTypeGeofence", "__Internal")]
        NSString PlotGeotriggerRegionTypeGeofence { get; }

        // extern NSString *const PlotGeotriggerRegionTypeBeacon;
        [Field("PlotGeotriggerRegionTypeBeacon", "__Internal")]
        NSString PlotGeotriggerRegionTypeBeacon { get; }
    }

    // @interface PlotFilterNotifications : NSObject
    [BaseType(typeof(NSObject))]
    interface PlotFilterNotifications
    {
        // @property (readonly, nonatomic, strong) NSArray<UNNotificationRequest *> * uiNotifications;
        [Export("uiNotifications", ArgumentSemantic.Strong)]
        UNNotificationRequest[] UiNotifications { get; }

        // -(void)showNotifications:(NSArray<UNNotificationRequest *> *)uiNotifications;
        [Export("showNotifications:")]
        void ShowNotifications(UNNotificationRequest[] uiNotifications);

        // +(NSArray *)testFilterNotifications:(NSArray<UNNotificationRequest *> *)notifications delegate:(id<PlotDelegate>)delegate;
        [Static]
        [Export("testFilterNotifications:delegate:")]
        NSObject[] TestFilterNotifications(UNNotificationRequest[] notifications, PlotDelegate @delegate);
    }

    // @interface PlotGeotrigger : NSObject
    [BaseType(typeof(NSObject))]
    interface PlotGeotrigger
    {
        // @property (copy, nonatomic) NSDictionary * userInfo;
        [Export("userInfo", ArgumentSemantic.Copy)]
        NSDictionary UserInfo { get; set; }

        // +(instancetype)initializeWithUserInfo:(NSDictionary *)userInfo;
        [Static]
        [Export("initializeWithUserInfo:")]
        PlotGeotrigger InitializeWithUserInfo(NSDictionary userInfo);
    }

    // @interface PlotHandleGeotriggers : NSObject
    [BaseType(typeof(NSObject))]
    interface PlotHandleGeotriggers
    {
        // @property (readonly, nonatomic, strong) NSArray<PlotGeotrigger *> * geotriggers;
        [Export("geotriggers", ArgumentSemantic.Strong)]
        PlotGeotrigger[] Geotriggers { get; }

        // -(void)markGeotriggersHandled:(NSArray<PlotGeotrigger *> *)geotriggers;
        [Export("markGeotriggersHandled:")]
        void MarkGeotriggersHandled(PlotGeotrigger[] geotriggers);

        // +(NSArray *)testHandleGeotriggers:(NSArray<PlotGeotrigger *> *)geotriggers delegate:(id<PlotDelegate>)delegate;
        [Static]
        [Export("testHandleGeotriggers:delegate:")]
        NSObject[] TestHandleGeotriggers(PlotGeotrigger[] geotriggers, PlotDelegate @delegate);
    }

    // @interface PlotSentNotification : NSObject
    [BaseType(typeof(NSObject))]
    interface PlotSentNotification
    {
        // @property (readonly, copy, nonatomic) NSDictionary * userInfo;
        [Export("userInfo", ArgumentSemantic.Copy)]
        NSDictionary UserInfo { get; }

        // @property (readonly, copy, nonatomic) NSDate * dateSent;
        [Export("dateSent", ArgumentSemantic.Copy)]
        NSDate DateSent { get; }

        // @property (readonly, copy, nonatomic) NSDate * dateOpened;
        [Export("dateOpened", ArgumentSemantic.Copy)]
        NSDate DateOpened { get; }

        // -(instancetype)initializeWithUserInfo:(NSDictionary *)userInfo dateSent:(NSDate *)dateSent dateOpened:(NSDate *)dateOpened;
        [Export("initializeWithUserInfo:dateSent:dateOpened:")]
        PlotSentNotification InitializeWithUserInfo(NSDictionary userInfo, NSDate dateSent, NSDate dateOpened);
    }

    // @interface PlotSentGeotrigger : NSObject
    [BaseType(typeof(NSObject))]
    interface PlotSentGeotrigger
    {
        // @property (readonly, copy, nonatomic) NSDictionary * userInfo;
        [Export("userInfo", ArgumentSemantic.Copy)]
        NSDictionary UserInfo { get; }

        // @property (readonly, copy, nonatomic) NSDate * dateSent;
        [Export("dateSent", ArgumentSemantic.Copy)]
        NSDate DateSent { get; }

        // @property (readonly, copy, nonatomic) NSDate * dateHandled;
        [Export("dateHandled", ArgumentSemantic.Copy)]
        NSDate DateHandled { get; }

        // -(instancetype)initializeWithUserInfo:(NSDictionary *)userInfo dateSent:(NSDate *)dateSent dateHandled:(NSDate *)dateHandled;
        [Export("initializeWithUserInfo:dateSent:dateHandled:")]
        PlotSentGeotrigger InitializeWithUserInfo(NSDictionary userInfo, NSDate dateSent, NSDate dateHandled);
    }

    // @protocol PlotDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface PlotDelegate
    {
        // Removed all members
    }

    // @interface PlotConfiguration : NSObject
    [BaseType(typeof(NSObject))]
    interface PlotConfiguration
    {
        // @property (assign, nonatomic) int cooldownPeriod __attribute__((deprecated("")));
        [Export("cooldownPeriod")]
        int CooldownPeriod { get; set; }

        // @property (nonatomic, strong) NSString * publicKey __attribute__((deprecated("")));
        [Export("publicKey", ArgumentSemantic.Strong)]
        string PublicKey { get; set; }

        // @property (nonatomic, strong) NSString * publicToken;
        [Export("publicToken", ArgumentSemantic.Strong)]
        string PublicToken { get; set; }

        [Wrap("WeakDelegate")]
        PlotDelegate Delegate { get; set; }

        // @property (nonatomic, strong) id<PlotDelegate> delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Strong)]
        NSObject WeakDelegate { get; set; }

        // @property (assign, nonatomic) BOOL enableOnFirstRun;
        [Export("enableOnFirstRun")]
        bool EnableOnFirstRun { get; set; }

        // @property (assign, nonatomic) int maxRegionsMonitored;
        [Export("maxRegionsMonitored")]
        int MaxRegionsMonitored { get; set; }

        // @property (assign, nonatomic) BOOL enableBackgroundModeWarning __attribute__((deprecated("")));
        [Export("enableBackgroundModeWarning")]
        bool EnableBackgroundModeWarning { get; set; }

        // @property (assign, nonatomic) BOOL automaticallyAskLocationPermission;
        [Export("automaticallyAskLocationPermission")]
        bool AutomaticallyAskLocationPermission { get; set; }

        // @property (assign, nonatomic) BOOL automaticallyAskNotificationPermission;
        [Export("automaticallyAskNotificationPermission")]
        bool AutomaticallyAskNotificationPermission { get; set; }

        // @property (assign, nonatomic) BOOL provisionalNotificationPermission;
        [Export("provisionalNotificationPermission")]
        bool ProvisionalNotificationPermission { get; set; }

        // @property (assign, nonatomic) BOOL quickSyncDisabled;
        [Export("quickSyncDisabled")]
        bool QuickSyncDisabled { get; set; }

        // @property (assign, nonatomic) BOOL enableBackgroundLocation;
        [Export("enableBackgroundLocation")]
        bool EnableBackgroundLocation { get; set; }

        // -(instancetype)initWithPublicKey:(NSString *)publicKey delegate:(id<PlotDelegate>)delegate;
        [Export("initWithPublicKey:delegate:")]
        IntPtr Constructor(string publicKey, PlotDelegate @delegate);
    }

    // @interface PlotBase : NSObject
    [BaseType(typeof(NSObject))]
    interface PlotBase
    {
        // +(void)initializeWithPublicKey:(NSString *)key launchOptions:(NSDictionary *)launchOptions __attribute__((deprecated("")));
        [Static]
        [Export("initializeWithPublicKey:launchOptions:")]
        void InitializeWithPublicKey(string key, NSDictionary launchOptions);

        // +(void)initializeWithPublicKey:(NSString *)key launchOptions:(NSDictionary *)launchOptions delegate:(id<PlotDelegate>)delegate __attribute__((deprecated("")));
        [Static]
        [Export("initializeWithPublicKey:launchOptions:delegate:")]
        void InitializeWithPublicKey(string key, NSDictionary launchOptions, PlotDelegate @delegate);

        // +(void)initializeWithConfiguration:(PlotConfiguration *)configuration launchOptions:(NSDictionary *)launchOptions __attribute__((deprecated("")));
        [Static]
        [Export("initializeWithConfiguration:launchOptions:")]
        void InitializeWithConfiguration(PlotConfiguration configuration, NSDictionary launchOptions);

        // +(void)initializeWithLaunchOptions:(NSDictionary *)launchOptions delegate:(id<PlotDelegate>)delegate;
        [Static]
        [Export("initializeWithLaunchOptions:delegate:")]
        void InitializeWithLaunchOptions(NSDictionary launchOptions, PlotDelegate @delegate);

        // +(void)enable;
        [Static]
        [Export("enable")]
        void Enable();

        // +(void)disable;
        [Static]
        [Export("disable")]
        void Disable();

        // +(void)setCooldownPeriod:(int)secondsCooldown;
        [Static]
        [Export("setCooldownPeriod:")]
        void SetCooldownPeriod(int secondsCooldown);

        // +(void)setEnableBackgroundModeWarning:(BOOL)enabled __attribute__((deprecated("")));
        [Static]
        [Export("setEnableBackgroundModeWarning:")]
        void SetEnableBackgroundModeWarning(bool enabled);

        // +(BOOL)isEnabled;
        [Static]
        [Export("isEnabled")]
        bool IsEnabled { get; }

        // +(void)setDelegate:(id<PlotDelegate>)delegate __attribute__((deprecated("")));
        [Static]
        [Export("setDelegate:")]
        void SetDelegate(PlotDelegate @delegate);

        // +(NSString *)version;
        [Static]
        [Export("version")]
        string Version { get; }

        // +(void)mailDebugLog:(UIViewController *)viewController;
        [Static]
        [Export("mailDebugLog:")]
        void MailDebugLog(UIViewController viewController);

        // +(void)setStringSegmentationProperty:(NSString *)value forKey:(NSString *)propertyKey;
        [Static]
        [Export("setStringSegmentationProperty:forKey:")]
        void SetStringSegmentationProperty(string value, string propertyKey);

        // +(void)setBooleanSegmentationProperty:(BOOL)value forKey:(NSString *)propertyKey;
        [Static]
        [Export("setBooleanSegmentationProperty:forKey:")]
        void SetBooleanSegmentationProperty(bool value, string propertyKey);

        // +(void)setIntegerSegmentationProperty:(long long)value forKey:(NSString *)propertyKey;
        [Static]
        [Export("setIntegerSegmentationProperty:forKey:")]
        void SetIntegerSegmentationProperty(long value, string propertyKey);

        // +(void)setDoubleSegmentationProperty:(double)value forKey:(NSString *)propertyKey;
        [Static]
        [Export("setDoubleSegmentationProperty:forKey:")]
        void SetDoubleSegmentationProperty(double value, string propertyKey);

        // +(void)setDateSegmentationProperty:(NSDate *)value forKey:(NSString *)propertyKey;
        [Static]
        [Export("setDateSegmentationProperty:forKey:")]
        void SetDateSegmentationProperty(NSDate value, string propertyKey);

        // +(void)setAdvertisingIdentifier:(NSUUID *)advertisingIdentifier advertisingTrackingEnabled:(BOOL)advertisingTrackingEnabled;
        [Static]
        [Export("setAdvertisingIdentifier:advertisingTrackingEnabled:")]
        void SetAdvertisingIdentifier(NSUuid advertisingIdentifier, bool advertisingTrackingEnabled);

        // +(NSArray<UNNotificationRequest *> *)loadedNotifications;
        [Static]
        [Export("loadedNotifications")]
        UNNotificationRequest[] LoadedNotifications { get; }

        // +(NSArray<PlotGeotrigger *> *)loadedGeotriggers;
        [Static]
        [Export("loadedGeotriggers")]
        PlotGeotrigger[] LoadedGeotriggers { get; }

        // +(NSArray<PlotSentNotification *> *)sentNotifications;
        [Static]
        [Export("sentNotifications")]
        PlotSentNotification[] SentNotifications { get; }

        // +(NSArray<PlotSentGeotrigger *> *)sentGeotriggers;
        [Static]
        [Export("sentGeotriggers")]
        PlotSentGeotrigger[] SentGeotriggers { get; }

        // +(void)clearSentNotifications;
        [Static]
        [Export("clearSentNotifications")]
        void ClearSentNotifications();

        // +(void)clearSentGeotriggers;
        [Static]
        [Export("clearSentGeotriggers")]
        void ClearSentGeotriggers();

        // +(void)sendAttributionEvent:(NSString *)action;
        [Static]
        [Export("sendAttributionEvent:")]
        void SendAttributionEvent(string action);

        // +(void)sendAttributionEvent:(NSString *)action withItemId:(NSString *)itemId;
        [Static]
        [Export("sendAttributionEvent:withItemId:")]
        void SendAttributionEvent(string action, string itemId);

        // +(void)requestContextualPage:(void (^)(NSString *))completionHandler;
        [Static]
        [Export("requestContextualPage:")]
        void RequestContextualPage(Action<NSString> completionHandler);

        // +(void)didRegisterForRemoteNotificationsWithDeviceToken:(NSData *)deviceToken;
        [Static]
        [Export("didRegisterForRemoteNotificationsWithDeviceToken:")]
        void DidRegisterForRemoteNotificationsWithDeviceToken(NSData deviceToken);

        // +(void)didFailToRegisterForRemoteNotificationsWithError:(NSError *)error;
        [Static]
        [Export("didFailToRegisterForRemoteNotificationsWithError:")]
        void DidFailToRegisterForRemoteNotificationsWithError(NSError error);

        // +(void)didReceiveRemoteNotification:(NSDictionary *)userInfo fetchCompletionHandler:(void (^)(UIBackgroundFetchResult))handler;
        [Static]
        [Export("didReceiveRemoteNotification:fetchCompletionHandler:")]
        void DidReceiveRemoteNotification(NSDictionary userInfo, Action<UIBackgroundFetchResult> handler);
    }

    // @interface PlotDebug : PlotBase
    [BaseType(typeof(PlotBase))]
    interface PlotDebug 
    {
    }

    // @interface PlotRelease : PlotBase
    [BaseType(typeof(PlotBase))]
    interface PlotRelease 
    {
    }
}

