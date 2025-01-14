<p align="center">
<img src="https://github.com/chkr1011/MQTTnet/blob/master/Images/icon_det_256.png?raw=true" width="196">
<br/>
<br/>
</p>

[![NuGet Badge](https://buildstats.info/nuget/MQTTnet)](https://www.nuget.org/packages/MQTTnet)
[![BCH compliance](https://bettercodehub.com/edge/badge/chkr1011/MQTTnet?branch=master)](https://bettercodehub.com/)
[![Join the chat at https://gitter.im/MQTTnet/community](https://badges.gitter.im/MQTTnet/community.svg)](https://gitter.im/MQTTnet/community?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
[![License: MIT](https://img.shields.io/badge/License-MIT-green.svg)](https://raw.githubusercontent.com/chkr1011/MQTTnet/master/LICENSE)

# MQTTnet

MQTTnet is a high performance .NET library for MQTT based communication. It provides a MQTT client and a MQTT server (broker). The implementation is based on the documentation from <http://mqtt.org/>.

## Features

### General

* Async support
* TLS support for client and server (but not UWP servers)
* Extensible communication channels (e.g. In-Memory, TCP, TCP+TLS, WS)
* Lightweight (only the low level implementation of MQTT, no overhead)
* Performance optimized (processing ~70.000 messages / second)*
* Uniform API across all supported versions of the MQTT protocol
* Interfaces included for mocking and testing
* Access to internal trace messages
* Unit tested (~250 tests)
* No external dependencies

\* Tested on local machine (Intel i7 8700K) with MQTTnet client and server running in the same process using the TCP channel. The app for verification is part of this repository and stored in _/Tests/MQTTnet.TestApp.NetCore_.

### Client

* Communication via TCP (+TLS) or WS (WebSocket) supported
* Included core _LowLevelMqttClient_ with low level functionality
* Also included _ManagedMqttClient_ which maintains the connection and subscriptions automatically. Also application messages are queued and re-scheduled for higher QoS levels automatically.
* Rx support (via another project)
* Compatible with Microsoft Azure IoT Hub

### Server (broker)

* List of connected clients available
* Supports connected clients with different protocol versions at the same time
* Able to publish its own messages (no loopback client required)
* Able to receive every message (no loopback client required)
* Extensible client credential validation
* Retained messages are supported including persisting via interface methods (own implementation required)
* WebSockets supported (via ASP.NET Core 2.0, separate nuget)
* A custom message interceptor can be added which allows transforming or extending every received application message
* Validate subscriptions and deny subscribing of certain topics depending on requesting clients
* Connect clients with different protocol versions at the same time.

## MQTTnet Server

_MQTTnet Server_ is a standalone cross platform MQTT server (like mosquitto) basing on this library. It has the following features.
* Running portable (no installation required)
* Runs under Windows, Linux, macOS, Raspberry Pi
* Python scripting support for manipulating messages, validation of clients, building business logic etc.
* Supports WebSocket and TCP (with and without TLS) connections
* Provides a HTTP based API (including Swagger endpoint)
* Extensive configuration parameters and customization supported

## Supported frameworks

* .NET 5.0+
* .NET Standard 1.3+
* .NET Core 1.1+
* .NET Core App 1.1+
* .NET Framework 4.5.2+
* Mono 5.2+
* Universal Windows Platform (UWP) 10.0.10240+ (Windows 10 IoT Core)
* Xamarin.Android 7.5+
* Xamarin.iOS 10.14+
* Blazor WebAssembly 3.2.0+

## Supported platforms

* x86
* x64
* AnyCPU
* ARM

## Supported OS

* Windows
* Windows 10 IoT Core
* Linux (Ubuntu, Raspbian etc.)
* macOS
* Android
* iOS

## Supported MQTT versions

* 5.0.0
* 3.1.1
* 3.1.0

## Nuget

This library is available as a nuget package: <https://www.nuget.org/packages/MQTTnet/>

## Examples

Please find examples and the documentation at the Wiki of this repository (<https://github.com/chkr1011/MQTTnet/wiki>).

## Contributions

If you want to contribute to this project just create a pull request. But only pull requests which are matching the code style of this library will be accepted. Before creating a pull request please have a look at the library to get an overview of the required style.
Also additions and updates in the Wiki are welcome.

## References

This library is used in the following projects:

* Azure Functions MQTT Bindings, <https://github.com/keesschollaart81/CaseOnline.Azure.WebJobs.Extensions.Mqtt>)
* HA4IoT (Open Source Home Automation system for .NET, <https://github.com/chkr1011/HA4IoT>)
* MQTT Client Rx (Wrapper for Reactive Extensions, <https://github.com/1iveowl/MQTTClient.rx>)
* MQTT Client Rx (Managed Client Wrapper for Reactive Extensions, <https://github.com/mmuecke/RxMQTTnet>)
* MQTT Tester (MQTT client test app for [Android](https://play.google.com/store/apps/details?id=com.liveowl.mqtttester) and [iOS](https://itunes.apple.com/us/app/mqtt-tester/id1278621826?mt=8))
* MQTTnet App (Cross platform client application for MQTT debugging, inspection etc., <https://github.com/chkr1011/MQTTnet.App>)
* Wirehome.Core (Open Source Home Automation system for .NET Core, <https://github.com/chkr1011/Wirehome.Core>)
* SparkplugNet (Sparkplug library for .Net, <https://github.com/SeppPenner/SparkplugNet>)
* Silverback (Framework to build event-driven applications - support for MQTT, Kafka & RabbitMQ) <https://github.com/BEagle1984/silverback>

Further projects using this project can be found under https://github.com/chkr1011/MQTTnet/network/dependents.

If you use this library and want to see your project here please create a pull request.

## License

MIT License

MQTTnet Copyright (c) 2016-2021 Christian Kratky

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
