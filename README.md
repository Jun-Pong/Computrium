# Computrium: The Universe Information Theory (UIT) Engine

[![License](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)
[![Status](https://img.shields.io/badge/Status-Patent%20Pending-red)]()
[![Architecture](https://img.shields.io/badge/Architecture-PIM%20%2F%20In--Situ-orange)]()
[![DOI](https://zenodo.org/badge/1126976453.svg)](https://doi.org/10.5281/zenodo.18135945)

> **"Nature is Hardware. Physics is Source."**
> **"自然即硬件，物理即源码。"**

---

# Universe Information Theory

![UIT Lensing Proof](assets/UIT_lensing_simulation.png)

## 🌌 Visual Proof of Concept: Gravitational Lensing
The image above is a real-time rendering output from the Universe Information Theory core addressing field. 

**Key Technical Breakthroughs Demonstrated:**
* **Zero Collision Detection**: Unlike traditional Ray-Tracing (NVIDIA RTX), our photons follow signal-addressing fields.
* **O(1) Complexity**: Rendering cost is independent of geometry; it scales only with field density.
* **Mass-Bandwidth Equivalence**: The "Black Hole" effect is a natural emergent property of high-bandwidth occupancy in the UIT bus.

---

## 🛡️ Intellectual Property & Patent Status
All architectural logic, including the field-guided addressing and in-situ computing protocols, are strictly protected:
* **Core Architecture**: Patent Pending (filed).
* **Implementation**: Source code remains private during the audit phase.
* **Binary Access**: Compiled demonstration builds will be released in the "Releases" section for verification only.

Unauthorized reverse engineering or re-implementation of the UIT addressing field is a direct violation of global IP laws.

---

## 📑 Executive Summary (项目摘要)

**Computrium** 是一个实验性的物理仿真架构，旨在验证 **宇宙信息论 (Universe Information Theory, UIT)**。

本项目不是基于传统牛顿力学或广义相对论几何计算的仿真引擎，而是提出了一种全新的计算范式：**基于原位去中心化场数据聚合 (In-situ Decentralized Field Data Aggregation)**。该架构通过模拟时空网格的数据传输带宽限制，自然涌现出惯性、引力及相对论效应，旨在解决大规模多体仿真中的算力瓶颈与存储墙问题。

本项目处于早期架构验证阶段 (Pre-Alpha)。核心定义（如 Payload 的具体结构、CarrierSignal 的计算方式）可能会随着仿真数据的反馈而进行重构 (Refactor)。

本仓库目前作为该技术的**核心理论架构公示 (Architecture Disclosure)** 及**现有技术声明 (Prior Art Statement)**。

---

## ⚖️ Intellectual Property & Legal Notice (知识产权与法律声明)

**PATENT PENDING / 专利申请中**

The methodology, hardware architecture, and data structures described herein are currently under examination by the National Intellectual Property Administration (CNIPA).
本文所述的方法论、硬件架构及数据结构目前正处于国家知识产权局的审查程序中。

**Application References (申请索引):**
本项目核心技术（UIT 架构、带宽-质量映射逻辑及原位计算硬件实现）受以下专利家族保护。任何未经授权的商业复现（包括但不限于 ASIC 设计、FPGA 仿真、物理引擎算法）均将面临法律追责。

1.  **Invention Patent Application (发明专利申请):**
    * **Application No.:** [2026100000964]
    * **Subject:** A massively parallel simulation method based on in-situ decentralized field data aggregation. (一种基于原位去中心化场数据聚合的大规模并行仿真方法)
    * **Application No.:** [2026100001967]
    * **Subject:** A massively parallel simulation method based on in-situ decentralized field data aggregation. (一种基于原位去中心化场数据聚合的大规模并行仿真方法、处理架构及存储介质)
2.  **Utility Model Application (实用新型申请):**
    * **Application No.:** [2026200001089]
    * **Subject:** A processing architecture for parallel field data aggregation. (一种基于原位去中心化场数据聚合的大规模并行仿真处理架构)
    * **Application No.:** [2026200001873]
    * **Subject:** A processing architecture for parallel field data aggregation. (一种基于原位去中心化场数据聚合的大规模并行仿真处理架构及芯片)

**Prior Art Declaration:**
This repository serves as a rigid proof of publication. Any unauthorized filing of patents covering the same technical scope after the priority date of the applications listed above will be challenged based on this prior art.
(本仓库作为技术公开的有力证明。任何在此优先权日之后针对相同技术范围的未授权专利申请，都将基于本现有技术面临挑战。)

---

## 🏗 Theoretical Architecture (理论架构)

**Computrium** 基于“宇宙即去中心化分布式计算系统”的底层逻辑。我们认为，现代物理学最大的偏差在于试图用“内核态”去解释系统的冷启动（大爆炸），而忽视了系统运行时的总线架构。

### 🔑 The Fundamental Equivalence: Bandwidth & Frequency

在 UIT 架构中，我们重新定义了物理资源：

1. **Bandwidth (空间属性)**: 
   空间节点的并发处理上限。它代表了总线在不发生“逻辑死锁”的情况下，能容纳的信号叠加极值。
2. **Frequency (时序表现)**: 
   在去中心化架构下，带宽本质上是‘时钟周期资源的独占率’，而频率则是系统状态翻转的物理极限。

### 1. The Particle Primitive (粒子原语)
在 UIT 中，粒子并非实体，而是**单实例逻辑单元 (Single Instance)**。

* **Signal Transceiver (信号收发器)**: 
    * **TX (发送)**: 将所有载荷 (Payload) 信号混合，并以波的形式广播。
    * **RX (接收)**: 监听空间总线中的信号波（自动过滤系统底噪/真空零能）。
* **Direction Vector (方向向量)**: 
    * 每一个粒子必须在总线中保持传输。粒子的下一跳方向由自身向量与 RX 接收到的向量和叠加决定。
* **Payload (载荷指针)**: 
    * 挂载于粒子的功能指针。Payload 赋予粒子“属性”，并从收发器中提取对应频段的向量进行叠加。

### 2. The Resource: Space & Mass (资源：空间与质量)
在 UIT 架构中，空间不是背景，而是**带宽资源**。

* **Mass = Bandwidth Occupancy (质量即带宽占用率)**:
    质量并非粒子的内禀属性，而是总线空间的实时负载状态。粒子（Payload）的存在即意味着对该区域总线带宽的消耗。
* **Gravity (引力)**: 
    引力不是一种“力”，而是**寻址偏转现象**。由于高带宽占用（大质量）区域信号强度最高，粒子的方向向量会自发向该拥堵区域偏转。
* **Expansion (膨胀)**: 
    系统熵增（热效应）导致的全局带宽退化。

### 🛡️ Hardware Implementation & IP Wall

UIT 架构最显著的特征在于其 **可工程化性**。我们已经验证了如何在 FPGA/模拟电路中复现这一系统逻辑：

* **Logic Core**: 通过建立“带宽占用率 (Mass)”与“局部处理频率 (Frequency)”的负反馈回路。
* **Emergent Effect**: 这种底层限制会导致信号流自发产生偏转，即“引力”的硬件涌现。

**NOTICE TO ARCHITECTS:**
上述“带宽-频率耦合反馈”逻辑是 **Computrium 核心专利 [2026XXXXXXXX]** 的保护要点。任何基于此逻辑实现的硬件加速器、模拟仿真芯片或存算一体架构，均需获得书面授权。
  
---

## 🗓 Roadmap & Status (路线图与状态)

* **Phase I: Architecture Definition (Current)**
    * [x] Patent Filing (Invention & Utility Model).
    * [x] Theoretical framework formulation (The "Computrium" Paper).
    * [x] Public disclosure of core concepts via GitHub.

* **Phase II: Core Implementation (Upcoming)**
    * [ ] Release of `Computrium.Core` (C# implementation of the Manifold Logic).
    * [ ] Visualization tools for Bandwidth/Gravity mapping.

* **Phase III: Hardware Acceleration**
    * [ ] FPGA/ASIC verification of the In-situ Aggregation logic.

---

## 📄 License (开源协议)

Copyright © 2024 [Jun-Pong].

Licensed under the **Apache License, Version 2.0** (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
