﻿using VersOne.Epub.Schema;

namespace VersOne.Epub.Test.Unit.Schema.Ops
{
    public class Epub3NavStructuralSemanticsPropertyTests
    {
        [Theory(DisplayName = "Converting a string to Epub3NavStructuralSemanticsProperty should succeed")]
        [InlineData("cover", Epub3NavStructuralSemanticsProperty.COVER)]
        [InlineData("frontmatter", Epub3NavStructuralSemanticsProperty.FRONTMATTER)]
        [InlineData("bodymatter", Epub3NavStructuralSemanticsProperty.BODYMATTER)]
        [InlineData("backmatter", Epub3NavStructuralSemanticsProperty.BACKMATTER)]
        [InlineData("volume", Epub3NavStructuralSemanticsProperty.VOLUME)]
        [InlineData("part", Epub3NavStructuralSemanticsProperty.PART)]
        [InlineData("chapter", Epub3NavStructuralSemanticsProperty.CHAPTER)]
        [InlineData("subchapter", Epub3NavStructuralSemanticsProperty.SUBCHAPTER)]
        [InlineData("division", Epub3NavStructuralSemanticsProperty.DIVISION)]
        [InlineData("abstract", Epub3NavStructuralSemanticsProperty.ABSTRACT)]
        [InlineData("foreword", Epub3NavStructuralSemanticsProperty.FOREWORD)]
        [InlineData("preface", Epub3NavStructuralSemanticsProperty.PREFACE)]
        [InlineData("prologue", Epub3NavStructuralSemanticsProperty.PROLOGUE)]
        [InlineData("introduction", Epub3NavStructuralSemanticsProperty.INTRODUCTION)]
        [InlineData("preamble", Epub3NavStructuralSemanticsProperty.PREAMBLE)]
        [InlineData("conclusion", Epub3NavStructuralSemanticsProperty.CONCLUSION)]
        [InlineData("epilogue", Epub3NavStructuralSemanticsProperty.EPILOGUE)]
        [InlineData("afterword", Epub3NavStructuralSemanticsProperty.AFTERWORD)]
        [InlineData("epigraph", Epub3NavStructuralSemanticsProperty.EPIGRAPH)]
        [InlineData("toc", Epub3NavStructuralSemanticsProperty.TOC)]
        [InlineData("toc-brief", Epub3NavStructuralSemanticsProperty.TOC_BRIEF)]
        [InlineData("landmarks", Epub3NavStructuralSemanticsProperty.LANDMARKS)]
        [InlineData("loa", Epub3NavStructuralSemanticsProperty.LOA)]
        [InlineData("loi", Epub3NavStructuralSemanticsProperty.LOI)]
        [InlineData("lot", Epub3NavStructuralSemanticsProperty.LOT)]
        [InlineData("lov", Epub3NavStructuralSemanticsProperty.LOV)]
        [InlineData("appendix", Epub3NavStructuralSemanticsProperty.APPENDIX)]
        [InlineData("colophon", Epub3NavStructuralSemanticsProperty.COLOPHON)]
        [InlineData("credits", Epub3NavStructuralSemanticsProperty.CREDITS)]
        [InlineData("keywords", Epub3NavStructuralSemanticsProperty.KEYWORDS)]
        [InlineData("index", Epub3NavStructuralSemanticsProperty.INDEX)]
        [InlineData("index-headnotes", Epub3NavStructuralSemanticsProperty.INDEX_HEADNOTES)]
        [InlineData("index-legend", Epub3NavStructuralSemanticsProperty.INDEX_LEGEND)]
        [InlineData("index-group", Epub3NavStructuralSemanticsProperty.INDEX_GROUP)]
        [InlineData("index-entry-list", Epub3NavStructuralSemanticsProperty.INDEX_ENTRY_LIST)]
        [InlineData("index-entry", Epub3NavStructuralSemanticsProperty.INDEX_ENTRY)]
        [InlineData("index-term", Epub3NavStructuralSemanticsProperty.INDEX_TERM)]
        [InlineData("index-editor-note", Epub3NavStructuralSemanticsProperty.INDEX_EDITOR_NOTE)]
        [InlineData("index-locator", Epub3NavStructuralSemanticsProperty.INDEX_LOCATOR)]
        [InlineData("index-locator-list", Epub3NavStructuralSemanticsProperty.INDEX_LOCATOR_LIST)]
        [InlineData("index-locator-range", Epub3NavStructuralSemanticsProperty.INDEX_LOCATOR_RANGE)]
        [InlineData("index-xref-preferred", Epub3NavStructuralSemanticsProperty.INDEX_XREF_PREFERRED)]
        [InlineData("index-xref-related", Epub3NavStructuralSemanticsProperty.INDEX_XREF_RELATED)]
        [InlineData("index-term-category", Epub3NavStructuralSemanticsProperty.INDEX_TERM_CATEGORY)]
        [InlineData("index-term-categories", Epub3NavStructuralSemanticsProperty.INDEX_TERM_CATEGORIES)]
        [InlineData("glossary", Epub3NavStructuralSemanticsProperty.GLOSSARY)]
        [InlineData("glossterm", Epub3NavStructuralSemanticsProperty.GLOSSTERM)]
        [InlineData("glossdef", Epub3NavStructuralSemanticsProperty.GLOSSDEF)]
        [InlineData("bibliography", Epub3NavStructuralSemanticsProperty.BIBLIOGRAPHY)]
        [InlineData("biblioentry", Epub3NavStructuralSemanticsProperty.BIBLIOENTRY)]
        [InlineData("titlepage", Epub3NavStructuralSemanticsProperty.TITLEPAGE)]
        [InlineData("halftitlepage", Epub3NavStructuralSemanticsProperty.HALFTITLEPAGE)]
        [InlineData("copyright-page", Epub3NavStructuralSemanticsProperty.COPYRIGHT_PAGE)]
        [InlineData("seriespage", Epub3NavStructuralSemanticsProperty.SERIESPAGE)]
        [InlineData("acknowledgments", Epub3NavStructuralSemanticsProperty.ACKNOWLEDGMENTS)]
        [InlineData("imprint", Epub3NavStructuralSemanticsProperty.IMPRINT)]
        [InlineData("imprimatur", Epub3NavStructuralSemanticsProperty.IMPRIMATUR)]
        [InlineData("contributors", Epub3NavStructuralSemanticsProperty.CONTRIBUTORS)]
        [InlineData("other-credits", Epub3NavStructuralSemanticsProperty.OTHER_CREDITS)]
        [InlineData("errata", Epub3NavStructuralSemanticsProperty.ERRATA)]
        [InlineData("dedication", Epub3NavStructuralSemanticsProperty.DEDICATION)]
        [InlineData("revision-history", Epub3NavStructuralSemanticsProperty.REVISION_HISTORY)]
        [InlineData("case-study", Epub3NavStructuralSemanticsProperty.CASE_STUDY)]
        [InlineData("help", Epub3NavStructuralSemanticsProperty.HELP)]
        [InlineData("marginalia", Epub3NavStructuralSemanticsProperty.MARGINALIA)]
        [InlineData("notice", Epub3NavStructuralSemanticsProperty.NOTICE)]
        [InlineData("pullquote", Epub3NavStructuralSemanticsProperty.PULLQUOTE)]
        [InlineData("sidebar", Epub3NavStructuralSemanticsProperty.SIDEBAR)]
        [InlineData("tip", Epub3NavStructuralSemanticsProperty.TIP)]
        [InlineData("warning", Epub3NavStructuralSemanticsProperty.WARNING)]
        [InlineData("halftitle", Epub3NavStructuralSemanticsProperty.HALFTITLE)]
        [InlineData("fulltitle", Epub3NavStructuralSemanticsProperty.FULLTITLE)]
        [InlineData("covertitle", Epub3NavStructuralSemanticsProperty.COVERTITLE)]
        [InlineData("title", Epub3NavStructuralSemanticsProperty.TITLE)]
        [InlineData("subtitle", Epub3NavStructuralSemanticsProperty.SUBTITLE)]
        [InlineData("label", Epub3NavStructuralSemanticsProperty.LABEL)]
        [InlineData("ordinal", Epub3NavStructuralSemanticsProperty.ORDINAL)]
        [InlineData("bridgehead", Epub3NavStructuralSemanticsProperty.BRIDGEHEAD)]
        [InlineData("learning-objective", Epub3NavStructuralSemanticsProperty.LEARNING_OBJECTIVE)]
        [InlineData("learning-objectives", Epub3NavStructuralSemanticsProperty.LEARNING_OBJECTIVES)]
        [InlineData("learning-outcome", Epub3NavStructuralSemanticsProperty.LEARNING_OUTCOME)]
        [InlineData("learning-outcomes", Epub3NavStructuralSemanticsProperty.LEARNING_OUTCOMES)]
        [InlineData("learning-resource", Epub3NavStructuralSemanticsProperty.LEARNING_RESOURCE)]
        [InlineData("learning-resources", Epub3NavStructuralSemanticsProperty.LEARNING_RESOURCES)]
        [InlineData("learning-standard", Epub3NavStructuralSemanticsProperty.LEARNING_STANDARD)]
        [InlineData("learning-standards", Epub3NavStructuralSemanticsProperty.LEARNING_STANDARDS)]
        [InlineData("answer", Epub3NavStructuralSemanticsProperty.ANSWER)]
        [InlineData("answers", Epub3NavStructuralSemanticsProperty.ANSWERS)]
        [InlineData("assessment", Epub3NavStructuralSemanticsProperty.ASSESSMENT)]
        [InlineData("assessments", Epub3NavStructuralSemanticsProperty.ASSESSMENTS)]
        [InlineData("feedback", Epub3NavStructuralSemanticsProperty.FEEDBACK)]
        [InlineData("fill-in-the-blank-problem", Epub3NavStructuralSemanticsProperty.FILL_IN_THE_BLANK_PROBLEM)]
        [InlineData("general-problem", Epub3NavStructuralSemanticsProperty.GENERAL_PROBLEM)]
        [InlineData("qna", Epub3NavStructuralSemanticsProperty.QNA)]
        [InlineData("match-problem", Epub3NavStructuralSemanticsProperty.MATCH_PROBLEM)]
        [InlineData("multiple-choice-problem", Epub3NavStructuralSemanticsProperty.MULTIPLE_CHOICE_PROBLEM)]
        [InlineData("practice", Epub3NavStructuralSemanticsProperty.PRACTICE)]
        [InlineData("question", Epub3NavStructuralSemanticsProperty.QUESTION)]
        [InlineData("practices", Epub3NavStructuralSemanticsProperty.PRACTICES)]
        [InlineData("true-false-problem", Epub3NavStructuralSemanticsProperty.TRUE_FALSE_PROBLEM)]
        [InlineData("panel", Epub3NavStructuralSemanticsProperty.PANEL)]
        [InlineData("panel-group", Epub3NavStructuralSemanticsProperty.PANEL_GROUP)]
        [InlineData("balloon", Epub3NavStructuralSemanticsProperty.BALLOON)]
        [InlineData("text-area", Epub3NavStructuralSemanticsProperty.TEXT_AREA)]
        [InlineData("sound-area", Epub3NavStructuralSemanticsProperty.SOUND_AREA)]
        [InlineData("annotation", Epub3NavStructuralSemanticsProperty.ANNOTATION)]
        [InlineData("note", Epub3NavStructuralSemanticsProperty.NOTE)]
        [InlineData("footnote", Epub3NavStructuralSemanticsProperty.FOOTNOTE)]
        [InlineData("endnote", Epub3NavStructuralSemanticsProperty.ENDNOTE)]
        [InlineData("rearnote", Epub3NavStructuralSemanticsProperty.REARNOTE)]
        [InlineData("footnotes", Epub3NavStructuralSemanticsProperty.FOOTNOTES)]
        [InlineData("endnotes", Epub3NavStructuralSemanticsProperty.ENDNOTES)]
        [InlineData("rearnotes", Epub3NavStructuralSemanticsProperty.REARNOTES)]
        [InlineData("annoref", Epub3NavStructuralSemanticsProperty.ANNOREF)]
        [InlineData("biblioref", Epub3NavStructuralSemanticsProperty.BIBLIOREF)]
        [InlineData("glossref", Epub3NavStructuralSemanticsProperty.GLOSSREF)]
        [InlineData("noteref", Epub3NavStructuralSemanticsProperty.NOTEREF)]
        [InlineData("backlink", Epub3NavStructuralSemanticsProperty.BACKLINK)]
        [InlineData("credit", Epub3NavStructuralSemanticsProperty.CREDIT)]
        [InlineData("keyword", Epub3NavStructuralSemanticsProperty.KEYWORD)]
        [InlineData("topic-sentence", Epub3NavStructuralSemanticsProperty.TOPIC_SENTENCE)]
        [InlineData("concluding-sentence", Epub3NavStructuralSemanticsProperty.CONCLUDING_SENTENCE)]
        [InlineData("pagebreak", Epub3NavStructuralSemanticsProperty.PAGEBREAK)]
        [InlineData("page-list", Epub3NavStructuralSemanticsProperty.PAGE_LIST)]
        [InlineData("table", Epub3NavStructuralSemanticsProperty.TABLE)]
        [InlineData("table-row", Epub3NavStructuralSemanticsProperty.TABLE_ROW)]
        [InlineData("table-cell", Epub3NavStructuralSemanticsProperty.TABLE_CELL)]
        [InlineData("list", Epub3NavStructuralSemanticsProperty.LIST)]
        [InlineData("list-item", Epub3NavStructuralSemanticsProperty.LIST_ITEM)]
        [InlineData("figure", Epub3NavStructuralSemanticsProperty.FIGURE)]
        [InlineData("aside", Epub3NavStructuralSemanticsProperty.ASIDE)]
        [InlineData("test-unknown-property", Epub3NavStructuralSemanticsProperty.UNKNOWN)]
        [InlineData("", Epub3NavStructuralSemanticsProperty.UNKNOWN)]
        [InlineData(null, Epub3NavStructuralSemanticsProperty.UNKNOWN)]
        public void ParseTest(string stringValue, Epub3NavStructuralSemanticsProperty expectedStructuralSemanticsProperty)
        {
            Epub3NavStructuralSemanticsProperty actualStructuralSemanticsProperty = Epub3NavStructuralSemanticsPropertyParser.Parse(stringValue);
            Assert.Equal(expectedStructuralSemanticsProperty, actualStructuralSemanticsProperty);
        }
    }
}