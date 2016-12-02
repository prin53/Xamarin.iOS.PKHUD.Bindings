using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace Xamarin.PKHUD
{
	// @interface PKHUD : NSObject
	[BaseType (typeof (NSObject), Name = "_TtC5PKHUD5PKHUD")]
	interface PKHUD
	{
		// @property (readonly, nonatomic, strong) PKHUD * _Nonnull sharedHUD;
		[Static, Export ("sharedHUD", ArgumentSemantic.Strong)]
		PKHUD SharedHUD { get; }

		// @property (nonatomic) BOOL dimsBackground;
		[Export ("dimsBackground")]
		bool DimsBackground { get; set; }

		// @property (nonatomic) BOOL userInteractionOnUnderlyingViewsEnabled;
		[Export ("userInteractionOnUnderlyingViewsEnabled")]
		bool UserInteractionOnUnderlyingViewsEnabled { get; set; }

		// @property (readonly, nonatomic) BOOL isVisible;
		[Export ("isVisible")]
		bool IsVisible { get; }

		// @property (nonatomic, strong) UIView * _Nonnull contentView;
		[Export ("contentView", ArgumentSemantic.Strong)]
		UIView ContentView { get; set; }

		// @property (nonatomic, strong) UIVisualEffect * _Nullable effect;
		[NullAllowed, Export ("effect", ArgumentSemantic.Strong)]
		UIVisualEffect Effect { get; set; }

		// -(void)show;
		[Export ("show")]
		void Show ();

		// -(void)hideWithAnimated:(BOOL)anim completion:(void (^ _Nullable)(BOOL))completion;
		[Export ("hideWithAnimated:completion:")]
		void HideWithAnimated (bool anim, [NullAllowed] Action<bool> completion);

		// -(void)hide:(BOOL)animated completion:(void (^ _Nullable)(BOOL))completion;
		[Export ("hide:completion:")]
		void Hide (bool animated, [NullAllowed] Action<bool> completion);

		// -(void)hideAfterDelay:(NSTimeInterval)delay completion:(void (^ _Nullable)(BOOL))completion;
		[Export ("hideAfterDelay:completion:")]
		void HideAfterDelay (double delay, [NullAllowed] Action<bool> completion);
	}

	// @interface PKHUDAssets : NSObject
	[BaseType (typeof (NSObject), Name = "_TtC5PKHUD11PKHUDAssets")]
	interface PKHUDAssets
	{
		// @property (readonly, nonatomic, strong) UIImage * _Nonnull crossImage;
		[Export ("crossImage", ArgumentSemantic.Strong)]
		UIImage CrossImage { get; }

		// @property (readonly, nonatomic, strong) UIImage * _Nonnull checkmarkImage;
		[Export ("checkmarkImage", ArgumentSemantic.Strong)]
		UIImage CheckmarkImage { get; }

		// @property (readonly, nonatomic, strong) UIImage * _Nonnull progressActivityImage;
		[Export ("progressActivityImage", ArgumentSemantic.Strong)]
		UIImage ProgressActivityImage { get; }

		// @property (readonly, nonatomic, strong) UIImage * _Nonnull progressCircularImage;
		[Export ("progressCircularImage", ArgumentSemantic.Strong)]
		UIImage ProgressCircularImage { get; }
	}

	// @interface PKHUDSquareBaseView : UIView
	[BaseType (typeof (UIView), Name = "_TtC5PKHUD19PKHUDSquareBaseView")]
	[DisableDefaultCtor]
	interface PKHUDSquareBaseView
	{
		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor (CGRect frame);

		// -(instancetype _Nonnull)initWithImage:(UIImage * _Nullable)image title:(NSString * _Nullable)title subtitle:(NSString * _Nullable)subtitle __attribute__((objc_designated_initializer));
		[Export ("initWithImage:title:subtitle:")]
		[DesignatedInitializer]
		IntPtr Constructor ([NullAllowed] UIImage image, [NullAllowed] string title, [NullAllowed] string subtitle);

		// @property (readonly, nonatomic, strong) UIImageView * _Nonnull imageView;
		[Export ("imageView", ArgumentSemantic.Strong)]
		UIImageView ImageView { get; }

		// @property (readonly, nonatomic, strong) UILabel * _Nonnull titleLabel;
		[Export ("titleLabel", ArgumentSemantic.Strong)]
		UILabel TitleLabel { get; }

		// @property (readonly, nonatomic, strong) UILabel * _Nonnull subtitleLabel;
		[Export ("subtitleLabel", ArgumentSemantic.Strong)]
		UILabel SubtitleLabel { get; }
	}

	// @interface PKHUDErrorView : PKHUDSquareBaseView
	[BaseType (typeof (PKHUDSquareBaseView), Name = "_TtC5PKHUD14PKHUDErrorView")]
	[DisableDefaultCtor]
	interface PKHUDErrorView
	{
		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor (CGRect frame);

		// -(instancetype _Nonnull)initWithTitle:(NSString * _Nullable)title subtitle:(NSString * _Nullable)subtitle __attribute__((objc_designated_initializer));
		[Export ("initWithTitle:subtitle:")]
		[DesignatedInitializer]
		IntPtr Constructor ([NullAllowed] string title, [NullAllowed] string subtitle);
	}

	// @interface PKHUDProgressView : PKHUDSquareBaseView
	[BaseType (typeof (PKHUDSquareBaseView), Name = "_TtC5PKHUD17PKHUDProgressView")]
	[DisableDefaultCtor]
	interface PKHUDProgressView
	{
		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor (CGRect frame);

		// -(instancetype _Nonnull)initWithTitle:(NSString * _Nullable)title subtitle:(NSString * _Nullable)subtitle __attribute__((objc_designated_initializer));
		[Export ("initWithTitle:subtitle:")]
		[DesignatedInitializer]
		IntPtr Constructor ([NullAllowed] string title, [NullAllowed] string subtitle);
	}

	// @interface PKHUDRotatingImageView : PKHUDSquareBaseView
	[BaseType (typeof (PKHUDSquareBaseView), Name = "_TtC5PKHUD22PKHUDRotatingImageView")]
	[DisableDefaultCtor]
	interface PKHUDRotatingImageView
	{
		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor (CGRect frame);

		// -(instancetype _Nonnull)initWithImage:(UIImage * _Nullable)image title:(NSString * _Nullable)title subtitle:(NSString * _Nullable)subtitle __attribute__((objc_designated_initializer));
		[Export ("initWithImage:title:subtitle:")]
		[DesignatedInitializer]
		IntPtr Constructor ([NullAllowed] UIImage image, [NullAllowed] string title, [NullAllowed] string subtitle);
	}

	// @interface PKHUDSuccessView : PKHUDSquareBaseView
	[BaseType (typeof (PKHUDSquareBaseView), Name = "_TtC5PKHUD16PKHUDSuccessView")]
	[DisableDefaultCtor]
	interface PKHUDSuccessView
	{
		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor (CGRect frame);

		// -(instancetype _Nonnull)initWithTitle:(NSString * _Nullable)title subtitle:(NSString * _Nullable)subtitle __attribute__((objc_designated_initializer));
		[Export ("initWithTitle:subtitle:")]
		[DesignatedInitializer]
		IntPtr Constructor ([NullAllowed] string title, [NullAllowed] string subtitle);

		// -(void)startAnimation;
		[Export ("startAnimation")]
		void StartAnimation ();

		// -(void)stopAnimation;
		[Export ("stopAnimation")]
		void StopAnimation ();
	}

	// @interface PKHUDSystemActivityIndicatorView : PKHUDSquareBaseView
	[BaseType (typeof (PKHUDSquareBaseView), Name = "_TtC5PKHUD32PKHUDSystemActivityIndicatorView")]
	[DisableDefaultCtor]
	interface PKHUDSystemActivityIndicatorView
	{
		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor (CGRect frame);
	}

	// @interface PKHUDWideBaseView : UIView
	[BaseType (typeof (UIView), Name = "_TtC5PKHUD17PKHUDWideBaseView")]
	[DisableDefaultCtor]
	interface PKHUDWideBaseView
	{
		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor (CGRect frame);
	}

	// @interface PKHUDTextView : PKHUDWideBaseView
	[BaseType (typeof (PKHUDWideBaseView), Name = "_TtC5PKHUD13PKHUDTextView")]
	[DisableDefaultCtor]
	interface PKHUDTextView
	{
		// -(instancetype _Nonnull)initWithText:(NSString * _Nullable)text __attribute__((objc_designated_initializer));
		[Export ("initWithText:")]
		[DesignatedInitializer]
		IntPtr Constructor ([NullAllowed] string text);

		// @property (readonly, nonatomic, strong) UILabel * _Nonnull titleLabel;
		[Export ("titleLabel", ArgumentSemantic.Strong)]
		UILabel TitleLabel { get; }
	}
}

