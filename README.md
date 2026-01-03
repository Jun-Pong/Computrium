# Computrium: The Universe Information Theory (UIT) Engine

[![License](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)
[![Status](https://img.shields.io/badge/Status-Patent%20Pending-red)]()
[![Architecture](https://img.shields.io/badge/Architecture-PIM%20%2F%20In--Situ-orange)]()
[![DOI](https://zenodo.org/badge/1126976453.svg)](https://doi.org/10.5281/zenodo.18135945)

> **"Data is Logic. Loading is Linkage."**
> **"数据即逻辑，加载即链接。"**

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
本技术受以下专利申请的保护范围覆盖：

1.  **Invention Patent Application (发明专利申请):**
    * **Application No.:** [2026100000964]
    * **Subject:** A massively parallel simulation method based on in-situ decentralized field data aggregation. (一种基于原位去中心化场数据聚合的大规模并行仿真方法)
2.  **Utility Model Application (实用新型申请):**
    * **Application No.:** [2026200001089]
    * **Subject:** A processing architecture for parallel field data aggregation. (一种基于原位去中心化场数据聚合的大规模并行仿真处理架构)

**Prior Art Declaration:**
This repository serves as a rigid proof of publication. Any unauthorized filing of patents covering the same technical scope after the priority date of the applications listed above will be challenged based on this prior art.
(本仓库作为技术公开的有力证明。任何在此优先权日之后针对相同技术范围的未授权专利申请，都将基于本现有技术面临挑战。)

---

## 🏗 Theoretical Architecture (理论架构)

Computrium 的核心逻辑并未采用 $F=ma$ 或几何碰撞检测，而是基于以下三条 **UIT 公理** 构建：

### 1. Mass-Information Equivalence (质量-信息等价)
* **传统物理**：质量是物体的内禀属性。
* **Computrium 定义**：质量被映射为仿真主体携带的 **信息载荷 (Information Payload)**。
* [cite_start]**机制**：粒子是一个载波容器。其携带的信息量越大，在网格中传输所需的“算力”和“带宽”越大，物理上表现为惯性越大 [cite: 3, 23]。

### 2. Gravity as Bandwidth Congestion (引力即带宽拥堵)
* **传统物理**：引力是时空的几何弯曲（广义相对论）。
* **Computrium 定义**：引力是局部存储空间的 **带宽拥堵 (Bandwidth Congestion)**。
* **机制**：
    * 空间被离散化为具有最大带宽限制的存储节点（Storage Nodes）。
    * 当高密度信息流（大质量物体）通过某区域时，该区域的可用带宽下降。
    * [cite_start]周围的信息流（其他粒子）在经过该拥堵区域时，传输速率受阻或路径发生偏折，宏观上表现为“被吸引”或“时间膨胀” [cite: 23]。

### 3. Dimensional Degradation Mapping (维度降解映射)
* 为了在现代计算机存储器上高效模拟高维空间，我们采用了 **维度降解 (Dimensional Degradation)** 算法。
* [cite_start]利用 **Z-Order Curve (Z阶曲线)** 或 Hilbert Curve 算法，将三维逻辑空间 $(x, y, z)$ 连续映射至一维物理内存地址。这确保了空间上相邻的粒子在内存中也是大概率相邻的，极大地优化了缓存命中率并适配存内计算 (PIM) 架构 [cite: 3, 4, 23]。

---

## ⚙️ Technical Specifications (技术规格)

本架构设计兼容未来的 **存算一体 (Processing-In-Memory, PIM)** 硬件，其核心处理流程如下：

1.  **Injector (注入):** 仿真主体将自身的载波向量 (Carrier Vector) 广播至所在的逻辑网格。
2.  [cite_start]**In-situ Aggregation (原位聚合):** 数据节点在本地执行“读-改-写”原子操作，计算信号叠加，无需将数据搬运至 CPU [cite: 7, 23]。
3.  [cite_start]**Feedback Loop (反馈循环):** 主体读取环境的信号密度梯度。如果目标区域信号密度超过阈值（带宽耗尽），系统自动施加反向矢量（模拟斥力），实现无需几何计算的 **隐式碰撞检测 (Implicit Collision Detection)** [cite: 6, 24]。

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
