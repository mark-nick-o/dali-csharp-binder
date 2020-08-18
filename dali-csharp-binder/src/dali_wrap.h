/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.9
 *
 * This file is not intended to be easily readable and contains a number of
 * coding conventions designed to improve portability and efficiency. Do not make
 * changes to this file unless you know what you are doing--modify the SWIG
 * interface file instead.
 * ----------------------------------------------------------------------------- */

#ifndef SWIG_NDalic_WRAP_H_
#define SWIG_NDalic_WRAP_H_

class SwigDirector_WidgetImpl : public Dali::Internal::Adaptor::Widget, public Swig::Director {

public:
    SwigDirector_WidgetImpl();
    virtual ~SwigDirector_WidgetImpl();
    virtual void OnCreate(std::string const &contentInfo, Dali::Window window);
    virtual void OnTerminate(std::string const &contentInfo, Dali::Widget::Termination type);
    virtual void OnPause();
    virtual void OnResume();
    virtual void OnResize(Dali::Window window);
    virtual void OnUpdate(std::string const &contentInfo, int force);
    virtual void SignalConnected(Dali::SlotObserver *slotObserver, Dali::CallbackBase *callback);
    virtual void SignalDisconnected(Dali::SlotObserver *slotObserver, Dali::CallbackBase *callback);

    typedef void (SWIGSTDCALL* SWIG_Callback0_t)(char *, void *);
    typedef void (SWIGSTDCALL* SWIG_Callback1_t)(char *, int);
    typedef void (SWIGSTDCALL* SWIG_Callback2_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback3_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback4_t)(void *);
    typedef void (SWIGSTDCALL* SWIG_Callback5_t)(char *, int);
    typedef void (SWIGSTDCALL* SWIG_Callback6_t)(void *, void *);
    typedef void (SWIGSTDCALL* SWIG_Callback7_t)(void *, void *);
    void swig_connect_director(SWIG_Callback0_t callbackOnCreate, SWIG_Callback1_t callbackOnTerminate, SWIG_Callback2_t callbackOnPause, SWIG_Callback3_t callbackOnResume, SWIG_Callback4_t callbackOnResize, SWIG_Callback5_t callbackOnUpdate, SWIG_Callback6_t callbackSignalConnected, SWIG_Callback7_t callbackSignalDisconnected);

private:
    SWIG_Callback0_t swig_callbackOnCreate;
    SWIG_Callback1_t swig_callbackOnTerminate;
    SWIG_Callback2_t swig_callbackOnPause;
    SWIG_Callback3_t swig_callbackOnResume;
    SWIG_Callback4_t swig_callbackOnResize;
    SWIG_Callback5_t swig_callbackOnUpdate;
    SWIG_Callback6_t swig_callbackSignalConnected;
    SWIG_Callback7_t swig_callbackSignalDisconnected;
    void swig_init_callbacks();
};

class SwigDirector_ViewImpl : public Dali::Toolkit::Internal::Control, public Swig::Director {

public:
    SwigDirector_ViewImpl(Dali::Toolkit::Internal::Control::ControlBehaviour behaviourFlags);
    virtual ~SwigDirector_ViewImpl();
    virtual void OnSceneConnection(int depth);
    virtual void OnSceneConnectionSwigPublic(int depth) {
      Dali::Toolkit::Internal::Control::OnSceneConnection(depth);
    }
    virtual void OnSceneDisconnection();
    virtual void OnSceneDisconnectionSwigPublic() {
      Dali::Toolkit::Internal::Control::OnSceneDisconnection();
    }
    virtual void OnChildAdd(Dali::Actor &child);
    virtual void OnChildAddSwigPublic(Dali::Actor &child) {
      Dali::Toolkit::Internal::Control::OnChildAdd(child);
    }
    virtual void OnChildRemove(Dali::Actor &child);
    virtual void OnChildRemoveSwigPublic(Dali::Actor &child) {
      Dali::Toolkit::Internal::Control::OnChildRemove(child);
    }
    virtual void OnPropertySet(Dali::Property::Index index, Dali::Property::Value propertyValue);
    virtual void OnPropertySetSwigPublic(Dali::Property::Index index, Dali::Property::Value propertyValue) {
      Dali::Toolkit::Internal::Control::OnPropertySet(index,propertyValue);
    }
    virtual void OnSizeSet(Dali::Vector3 const &targetSize);
    virtual void OnSizeSetSwigPublic(Dali::Vector3 const &targetSize) {
      Dali::Toolkit::Internal::Control::OnSizeSet(targetSize);
    }
    virtual void OnSizeAnimation(Dali::Animation &animation, Dali::Vector3 const &targetSize);
    virtual void OnSizeAnimationSwigPublic(Dali::Animation &animation, Dali::Vector3 const &targetSize) {
      Dali::Toolkit::Internal::Control::OnSizeAnimation(animation,targetSize);
    }
    virtual bool OnHoverEvent(Dali::HoverEvent const &event);
    virtual bool OnHoverEventSwigPublic(Dali::HoverEvent const &event) {
      return Dali::Toolkit::Internal::Control::OnHoverEvent(event);
    }
    virtual bool OnKeyEvent(Dali::KeyEvent const &event);
    virtual bool OnKeyEventSwigPublic(Dali::KeyEvent const &event) {
      return Dali::Toolkit::Internal::Control::OnKeyEvent(event);
    }
    virtual bool OnWheelEvent(Dali::WheelEvent const &event);
    virtual bool OnWheelEventSwigPublic(Dali::WheelEvent const &event) {
      return Dali::Toolkit::Internal::Control::OnWheelEvent(event);
    }
    virtual void OnRelayout(Dali::Vector2 const &size, Dali::RelayoutContainer &container);
    virtual void OnRelayoutSwigPublic(Dali::Vector2 const &size, Dali::RelayoutContainer &container) {
      Dali::Toolkit::Internal::Control::OnRelayout(size,container);
    }
    virtual void OnSetResizePolicy(Dali::ResizePolicy::Type policy, Dali::Dimension::Type dimension);
    virtual void OnSetResizePolicySwigPublic(Dali::ResizePolicy::Type policy, Dali::Dimension::Type dimension) {
      Dali::Toolkit::Internal::Control::OnSetResizePolicy(policy,dimension);
    }
    virtual Dali::Vector3 GetNaturalSize();
    virtual Dali::Vector3 GetNaturalSizeSwigPublic() {
      return Dali::Toolkit::Internal::Control::GetNaturalSize();
    }
    virtual float CalculateChildSize(Dali::Actor const &child, Dali::Dimension::Type dimension);
    virtual float CalculateChildSizeSwigPublic(Dali::Actor const &child, Dali::Dimension::Type dimension) {
      return Dali::Toolkit::Internal::Control::CalculateChildSize(child,dimension);
    }
    virtual float GetHeightForWidth(float width);
    virtual float GetHeightForWidthSwigPublic(float width) {
      return Dali::Toolkit::Internal::Control::GetHeightForWidth(width);
    }
    virtual float GetWidthForHeight(float height);
    virtual float GetWidthForHeightSwigPublic(float height) {
      return Dali::Toolkit::Internal::Control::GetWidthForHeight(height);
    }
    virtual bool RelayoutDependentOnChildren(Dali::Dimension::Type dimension = Dali::Dimension::ALL_DIMENSIONS);
    virtual bool RelayoutDependentOnChildrenSwigPublic(Dali::Dimension::Type dimension = Dali::Dimension::ALL_DIMENSIONS) {
      return Dali::Toolkit::Internal::Control::RelayoutDependentOnChildren(dimension);
    }
    virtual void OnCalculateRelayoutSize(Dali::Dimension::Type dimension);
    virtual void OnCalculateRelayoutSizeSwigPublic(Dali::Dimension::Type dimension) {
      Dali::Toolkit::Internal::Control::OnCalculateRelayoutSize(dimension);
    }
    virtual void OnLayoutNegotiated(float size, Dali::Dimension::Type dimension);
    virtual void OnLayoutNegotiatedSwigPublic(float size, Dali::Dimension::Type dimension) {
      Dali::Toolkit::Internal::Control::OnLayoutNegotiated(size,dimension);
    }
    virtual Dali::CustomActorImpl::Extension *GetExtension();
    virtual void OnInitialize();
    virtual void OnStyleChange(Dali::Toolkit::StyleManager styleManager, Dali::StyleChange::Type change);
    virtual bool OnAccessibilityActivated();
    virtual bool OnAccessibilityPan(Dali::PanGesture gesture);
    virtual bool OnAccessibilityTouch(Dali::TouchEvent const &touch);
    virtual bool OnAccessibilityValueChange(bool isIncrease);
    virtual bool OnAccessibilityZoom();
    virtual void OnKeyInputFocusGained();
    virtual void OnKeyInputFocusLost();
    virtual Dali::Actor GetNextKeyboardFocusableActor(Dali::Actor currentFocusedActor, Dali::Toolkit::Control::KeyboardFocus::Direction direction, bool loopEnabled);
    virtual void OnKeyboardFocusChangeCommitted(Dali::Actor commitedFocusableActor);
    virtual bool OnKeyboardEnter();
    virtual void OnPinch(Dali::PinchGesture const &pinch);
    virtual void OnPan(Dali::PanGesture const &pan);
    virtual void OnTap(Dali::TapGesture const &tap);
    virtual void OnLongPress(Dali::LongPressGesture const &longPress);
    virtual void SignalConnected(Dali::SlotObserver *slotObserver, Dali::CallbackBase *callback);
    virtual void SignalDisconnected(Dali::SlotObserver *slotObserver, Dali::CallbackBase *callback);
    virtual Dali::Toolkit::Internal::Control::Extension *GetControlExtension();

    typedef void (SWIGSTDCALL* SWIG_Callback0_t)(int);
    typedef void (SWIGSTDCALL* SWIG_Callback1_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback2_t)(void *);
    typedef void (SWIGSTDCALL* SWIG_Callback3_t)(void *);
    typedef void (SWIGSTDCALL* SWIG_Callback4_t)(int, void *);
    typedef void (SWIGSTDCALL* SWIG_Callback5_t)(void *);
    typedef void (SWIGSTDCALL* SWIG_Callback6_t)(void *, void *);
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback8_t)(void *);
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback9_t)(void *);
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback10_t)(void *);
    typedef void (SWIGSTDCALL* SWIG_Callback11_t)(void *, void *);
    typedef void (SWIGSTDCALL* SWIG_Callback12_t)(int, int);
    typedef void * (SWIGSTDCALL* SWIG_Callback13_t)();
    typedef float (SWIGSTDCALL* SWIG_Callback14_t)(void *, int);
    typedef float (SWIGSTDCALL* SWIG_Callback15_t)(float);
    typedef float (SWIGSTDCALL* SWIG_Callback16_t)(float);
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback17_t)(int);
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback18_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback19_t)(int);
    typedef void (SWIGSTDCALL* SWIG_Callback20_t)(float, int);
    typedef void (SWIGSTDCALL* SWIG_Callback21_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback22_t)(void *);
    typedef void (SWIGSTDCALL* SWIG_Callback23_t)(void *);
    typedef void (SWIGSTDCALL* SWIG_Callback24_t)(void *, int);
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback25_t)();
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback26_t)(void *);
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback27_t)(void *);
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback28_t)(unsigned int);
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback29_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback30_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback31_t)();
    typedef void * (SWIGSTDCALL* SWIG_Callback32_t)(void *, int, unsigned int);
    typedef void (SWIGSTDCALL* SWIG_Callback33_t)(void *);
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback34_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback35_t)(void *);
    typedef void (SWIGSTDCALL* SWIG_Callback36_t)(void *);
    typedef void (SWIGSTDCALL* SWIG_Callback37_t)(void *);
    typedef void (SWIGSTDCALL* SWIG_Callback38_t)(void *);
    typedef void (SWIGSTDCALL* SWIG_Callback39_t)(void *, void *);
    typedef void (SWIGSTDCALL* SWIG_Callback40_t)(void *, void *);
    void swig_connect_director(SWIG_Callback0_t callbackOnSceneConnection, SWIG_Callback1_t callbackOnSceneDisconnection, SWIG_Callback2_t callbackOnChildAdd, SWIG_Callback3_t callbackOnChildRemove, SWIG_Callback4_t callbackOnPropertySet, SWIG_Callback5_t callbackOnSizeSet, SWIG_Callback6_t callbackOnSizeAnimation, SWIG_Callback8_t callbackOnHoverEvent, SWIG_Callback9_t callbackOnKeyEvent, SWIG_Callback10_t callbackOnWheelEvent, SWIG_Callback11_t callbackOnRelayout, SWIG_Callback12_t callbackOnSetResizePolicy, SWIG_Callback13_t callbackGetNaturalSize, SWIG_Callback14_t callbackCalculateChildSize, SWIG_Callback15_t callbackGetHeightForWidth, SWIG_Callback16_t callbackGetWidthForHeight, SWIG_Callback17_t callbackRelayoutDependentOnChildren__SWIG_0, SWIG_Callback18_t callbackRelayoutDependentOnChildren__SWIG_1, SWIG_Callback19_t callbackOnCalculateRelayoutSize, SWIG_Callback20_t callbackOnLayoutNegotiated, SWIG_Callback21_t callbackOnInitialize, SWIG_Callback24_t callbackOnStyleChange, SWIG_Callback25_t callbackOnAccessibilityActivated, SWIG_Callback26_t callbackOnAccessibilityPan, SWIG_Callback27_t callbackOnAccessibilityTouch, SWIG_Callback28_t callbackOnAccessibilityValueChange, SWIG_Callback29_t callbackOnAccessibilityZoom, SWIG_Callback30_t callbackOnKeyInputFocusGained, SWIG_Callback31_t callbackOnKeyInputFocusLost, SWIG_Callback32_t callbackGetNextKeyboardFocusableActor, SWIG_Callback33_t callbackOnKeyboardFocusChangeCommitted, SWIG_Callback34_t callbackOnKeyboardEnter, SWIG_Callback35_t callbackOnPinch, SWIG_Callback36_t callbackOnPan, SWIG_Callback37_t callbackOnTap, SWIG_Callback38_t callbackOnLongPress, SWIG_Callback39_t callbackSignalConnected, SWIG_Callback40_t callbackSignalDisconnected);

private:
    SWIG_Callback0_t swig_callbackOnSceneConnection;
    SWIG_Callback1_t swig_callbackOnSceneDisconnection;
    SWIG_Callback2_t swig_callbackOnChildAdd;
    SWIG_Callback3_t swig_callbackOnChildRemove;
    SWIG_Callback4_t swig_callbackOnPropertySet;
    SWIG_Callback5_t swig_callbackOnSizeSet;
    SWIG_Callback6_t swig_callbackOnSizeAnimation;
    SWIG_Callback8_t swig_callbackOnHoverEvent;
    SWIG_Callback9_t swig_callbackOnKeyEvent;
    SWIG_Callback10_t swig_callbackOnWheelEvent;
    SWIG_Callback11_t swig_callbackOnRelayout;
    SWIG_Callback12_t swig_callbackOnSetResizePolicy;
    SWIG_Callback13_t swig_callbackGetNaturalSize;
    SWIG_Callback14_t swig_callbackCalculateChildSize;
    SWIG_Callback15_t swig_callbackGetHeightForWidth;
    SWIG_Callback16_t swig_callbackGetWidthForHeight;
    SWIG_Callback17_t swig_callbackRelayoutDependentOnChildren__SWIG_0;
    SWIG_Callback18_t swig_callbackRelayoutDependentOnChildren__SWIG_1;
    SWIG_Callback19_t swig_callbackOnCalculateRelayoutSize;
    SWIG_Callback20_t swig_callbackOnLayoutNegotiated;
    SWIG_Callback21_t swig_callbackOnInitialize;
    SWIG_Callback24_t swig_callbackOnStyleChange;
    SWIG_Callback25_t swig_callbackOnAccessibilityActivated;
    SWIG_Callback26_t swig_callbackOnAccessibilityPan;
    SWIG_Callback27_t swig_callbackOnAccessibilityTouch;
    SWIG_Callback28_t swig_callbackOnAccessibilityValueChange;
    SWIG_Callback29_t swig_callbackOnAccessibilityZoom;
    SWIG_Callback30_t swig_callbackOnKeyInputFocusGained;
    SWIG_Callback31_t swig_callbackOnKeyInputFocusLost;
    SWIG_Callback32_t swig_callbackGetNextKeyboardFocusableActor;
    SWIG_Callback33_t swig_callbackOnKeyboardFocusChangeCommitted;
    SWIG_Callback34_t swig_callbackOnKeyboardEnter;
    SWIG_Callback35_t swig_callbackOnPinch;
    SWIG_Callback36_t swig_callbackOnPan;
    SWIG_Callback37_t swig_callbackOnTap;
    SWIG_Callback38_t swig_callbackOnLongPress;
    SWIG_Callback39_t swig_callbackSignalConnected;
    SWIG_Callback40_t swig_callbackSignalDisconnected;
    void swig_init_callbacks();
};

class SwigDirector_ItemFactory : public Dali::Toolkit::ItemFactory, public Swig::Director {

public:
    SwigDirector_ItemFactory();
    virtual ~SwigDirector_ItemFactory();
    virtual unsigned int GetNumberOfItems();
    virtual Dali::Actor NewItem(unsigned int itemId);
    virtual void ItemReleased(unsigned int itemId, Dali::Actor actor);
    virtual Dali::Toolkit::ItemFactory::Extension *GetExtension();

    typedef unsigned int (SWIGSTDCALL* SWIG_Callback0_t)();
    typedef void * (SWIGSTDCALL* SWIG_Callback1_t)(unsigned int);
    typedef void (SWIGSTDCALL* SWIG_Callback2_t)(unsigned int, void *);
    void swig_connect_director(SWIG_Callback0_t callbackGetNumberOfItems, SWIG_Callback1_t callbackNewItem, SWIG_Callback2_t callbackItemReleased);

private:
    SWIG_Callback0_t swig_callbackGetNumberOfItems;
    SWIG_Callback1_t swig_callbackNewItem;
    SWIG_Callback2_t swig_callbackItemReleased;
    void swig_init_callbacks();
};

class SwigDirector_CustomAlgorithmInterface : public Dali::Toolkit::DevelKeyboardFocusManager::CustomAlgorithmInterface, public Swig::Director {

public:
    SwigDirector_CustomAlgorithmInterface();
    virtual ~SwigDirector_CustomAlgorithmInterface();
    virtual Dali::Actor GetNextFocusableActor(Dali::Actor current, Dali::Actor proposed, Dali::Toolkit::Control::KeyboardFocus::Direction direction);

    typedef void * (SWIGSTDCALL* SWIG_Callback0_t)(void *, void *, int);
    void swig_connect_director(SWIG_Callback0_t callbackGetNextFocusableActor);

private:
    SWIG_Callback0_t swig_callbackGetNextFocusableActor;
    void swig_init_callbacks();
};

class SwigDirector_FrameCallbackInterface : public Dali::FrameCallbackInterface, public Swig::Director {
public:
    SwigDirector_FrameCallbackInterface();
    virtual ~SwigDirector_FrameCallbackInterface();
    virtual void Update( Dali::UpdateProxy& updateProxy, float elapsedSeconds );

    typedef void (SWIGSTDCALL* SWIG_Callback0_t)( void*  updateProxy, float elapsedSeconds );
    void swig_connect_director( SWIG_Callback0_t callbackUpdate );


private:
    SWIG_Callback0_t swig_callbackOnUpdate;
};

#endif
