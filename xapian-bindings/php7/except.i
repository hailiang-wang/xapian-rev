%{
/** @file php/except.i
 * @brief Custom PHP exception handling.
 */
/* Warning: This file is generated by ./generate-php-exceptions
 * - do not modify directly!
 *
 * Copyright 2006,2007,2010,2011,2012,2016 Olly Betts
 * Copyright 2007 Lemur Consulting Ltd
 *
 * This program is free software; you can redistribute it and/or
 * modify it under the terms of the GNU General Public License as
 * published by the Free Software Foundation; either version 2 of the
 * License, or (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301 USA
 */

#include <exception>
#include <zend_exceptions.h>

static void
XapianExceptionHandler()
{
    try {
	// Rethrow so we can look at the exception if it was a Xapian::Error.
	throw;
    } catch (const Xapian::Error &e) {
        // FIXME: It would be nicer to make the exceptions PHP classes
        // corresponding to the C++ Xapian::Error class hierarchy.
	zend_throw_exception(NULL, e.get_description().c_str(),
			     SWIG_UnknownError);
    } catch (const std::exception &e) {
	zend_throw_exception_ex(NULL, SWIG_UnknownError,
				"std::exception %s", e.what());
    } catch (...) {
	zend_throw_exception(NULL, "unknown error in Xapian",
			     SWIG_UnknownError);
    }
}
%}

/* Functions and methods which are marked as "nothrow": */
%exception Xapian::Compactor::get_constinfo_();
%exception Xapian::Database::postlist_end(const std::string &) const;
%exception Xapian::Database::termlist_end(Xapian::docid) const;
%exception Xapian::Database::positionlist_end(Xapian::docid, const std::string &) const;
%exception Xapian::Database::allterms_end(const std::string & = std::string()) const;
%exception Xapian::Database::valuestream_end(Xapian::valueno) const;
%exception Xapian::Database::spellings_end() const;
%exception Xapian::Database::synonyms_end(const std::string &) const;
%exception Xapian::Database::synonym_keys_end(const std::string & = std::string()) const;
%exception Xapian::Database::metadata_keys_end(const std::string & = std::string()) const;
%exception Xapian::Document::termlist_end() const;
%exception Xapian::Document::values_end() const;
%exception Xapian::Enquire::get_matching_terms_end(Xapian::docid  ) const;
%exception Xapian::Enquire::get_matching_terms_end(const MSetIterator & ) const;
%exception Xapian::Error::get_type() const;
%exception Xapian::Error::get_msg() const;
%exception Xapian::Error::get_context() const;
%exception Xapian::ErrorHandler::ErrorHandler();
%exception Xapian::ESetIterator::operator==(const ESetIterator &a, const ESetIterator &b);
%exception Xapian::ESetIterator::operator!=(const ESetIterator &a, const ESetIterator &b);
%exception Xapian::ESetIterator::operator<(const ESetIterator &a, const ESetIterator &b);
%exception Xapian::ESetIterator::operator>(const ESetIterator &a, const ESetIterator &b);
%exception Xapian::ESetIterator::operator>=(const ESetIterator &a, const ESetIterator &b);
%exception Xapian::ESetIterator::operator<=(const ESetIterator &a, const ESetIterator &b);
%exception Xapian::ExpandDeciderFilterPrefix::miles_to_metres(double miles);
%exception Xapian::ExpandDeciderFilterPrefix::metres_to_miles(double metres);
%exception Xapian::ExpandDeciderFilterPrefix::LatLongCoord();
%exception Xapian::ExpandDeciderFilterPrefix::operator<(const LatLongCoord & other) const;
%exception Xapian::MatchSpy::MatchSpy();
%exception Xapian::ValueCountMatchSpy::get_total() const;
%exception Xapian::ValueCountMatchSpy::values_end() const;
%exception Xapian::ValueCountMatchSpy::top_values_end(size_t) const;
%exception Xapian::MSetIterator::operator==(const MSetIterator &a, const MSetIterator &b);
%exception Xapian::MSetIterator::operator!=(const MSetIterator &a, const MSetIterator &b);
%exception Xapian::MSetIterator::operator<(const MSetIterator &a, const MSetIterator &b);
%exception Xapian::MSetIterator::operator>(const MSetIterator &a, const MSetIterator &b);
%exception Xapian::MSetIterator::operator>=(const MSetIterator &a, const MSetIterator &b);
%exception Xapian::MSetIterator::operator<=(const MSetIterator &a, const MSetIterator &b);
%exception Xapian::PositionIterator::PositionIterator();
%exception Xapian::PositionIterator::operator==(const PositionIterator &a, const PositionIterator &b);
%exception Xapian::PositionIterator::operator!=(const PositionIterator &a, const PositionIterator &b);
%exception Xapian::PostingIterator::PostingIterator();
%exception Xapian::PostingIterator::positionlist_end() const;
%exception Xapian::PostingIterator::operator==(const PostingIterator &a, const PostingIterator &b);
%exception Xapian::PostingIterator::operator!=(const PostingIterator &a, const PostingIterator &b);
%exception Xapian::PostingSource::PostingSource();
%exception Xapian::PostingSource::get_maxweight() const;
%exception Xapian::Query::Query();
%exception Xapian::Query::get_terms_end() const;
%exception Xapian::Query::get_length() const;
%exception Xapian::Query::empty() const;
%exception Xapian::Query::get_type() const;
%exception Xapian::Query::get_num_subqueries() const;
%exception Xapian::Query::Internal();
%exception Xapian::Query::get_length() const;
%exception Xapian::Query::get_type() const;
%exception Xapian::Query::get_num_subqueries() const;
%exception Xapian::QueryParser::stoplist_end() const;
%exception Xapian::QueryParser::unstem_end(const std::string &) const;
%exception Xapian::QueryParser::sortable_serialise_(double value, char * buf);
%exception Xapian::QueryParser::sortable_unserialise(const std::string & serialised);
%exception Xapian::TermIterator::TermIterator();
%exception Xapian::TermIterator::positionlist_end() const;
%exception Xapian::TermIterator::operator==(const TermIterator &a, const TermIterator &b);
%exception Xapian::TermIterator::operator!=(const TermIterator &a, const TermIterator &b);
%exception Xapian::Utf8Iterator::calculate_sequence_length() const;
%exception Xapian::Utf8Iterator::Utf8Iterator();
%exception Xapian::Utf8Iterator::operator*() const;
%exception Xapian::Utf8Iterator::strict_deref() const;
%exception Xapian::Utf8Iterator::operator==(const Utf8Iterator &other) const;
%exception Xapian::Utf8Iterator::operator!=(const Utf8Iterator &other) const;
%exception Xapian::Utf8Iterator::get_character_info(unsigned ch);
%exception Xapian::ValueIterator::ValueIterator();
%exception Xapian::ValueIterator::operator==(const ValueIterator &a, const ValueIterator &b);
%exception Xapian::ValueIterator::operator!=(const ValueIterator &a, const ValueIterator &b);

%exception {
    try {
	$function
    } catch (...) {
	XapianExceptionHandler();
	return;
    }
}
